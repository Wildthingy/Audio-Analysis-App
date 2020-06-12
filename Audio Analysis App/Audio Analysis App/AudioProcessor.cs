using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using DSPLib;

namespace Audio_Analysis_App
{
    class AudioProcessor
    {
        // Constructor
        public AudioProcessor(AudioFileReader song)
        {
            audioSource = song;
            channels = audioSource.WaveFormat.Channels;
            sampleRate = audioSource.WaveFormat.SampleRate;
            timeInSeconds = (int)audioSource.TotalTime.TotalSeconds;
            sampleCount = sampleRate * timeInSeconds;

            process();
        }

        AudioFileReader audioSource;
        int channels;
        int sampleRate;
        int timeInSeconds;
        int sampleCount;
        float[] audioBuffer;
        SpectralFluxAnalyser SFAnalyser;
        
        void process()
        {
            audioBuffer = new float[sampleCount * channels];
            audioSource.Read(audioBuffer, 0, sampleCount * channels);

            float[] preProcessedSamples = new float[sampleCount];

            int numProcessed = 0;
            float combinedChannelAverage = 0f;
            for (int i = 0; i < audioBuffer.Length; i++)
            {
                combinedChannelAverage += audioBuffer[i];

                // Each time we have processed all channels samples for a point in time, we will store the average of the channels combined
                if ((i + 1) % channels == 0)
                {
                    preProcessedSamples[numProcessed] = combinedChannelAverage / channels;
                    numProcessed++;
                    combinedChannelAverage = 0f;
                }
            }

            // Once we have our audio sample data prepared, we can execute an FFT to return the spectrum data over the time domain
            int spectrumSampleSize = 512;
            int iterations = preProcessedSamples.Length / spectrumSampleSize;

            GlobalVariables.entryNo = 0;
            GlobalVariables.times = new float[iterations];
            GlobalVariables.thresholds = new float[iterations];
            GlobalVariables.prunedSFValues = new float[iterations];
            GlobalVariables.beats = new bool[iterations];
            GlobalVariables.intensityChanged = new bool[iterations];
            GlobalVariables.intensityLevel = new int[iterations];
            GlobalVariables.numBeats = 0;

            FFT fft = new FFT();
            fft.Initialize((UInt32)spectrumSampleSize);
            
            SFAnalyser = new SpectralFluxAnalyser();

            double[] sampleChunk = new double[spectrumSampleSize];
            for (int i = 0; i < iterations; i++)
            {
                // Grab the current 1024 chunk of audio sample data
                Array.Copy(preProcessedSamples, i * spectrumSampleSize, sampleChunk, 0, spectrumSampleSize);

                // Apply our chosen FFT Window
                double[] windowCoefs = DSP.Window.Coefficients(DSP.Window.Type.Hanning, (uint)spectrumSampleSize);
                double[] scaledSpectrumChunk = DSP.Math.Multiply(sampleChunk, windowCoefs);
                double scaleFactor = DSP.Window.ScaleFactor.Signal(windowCoefs);

                // Perform the FFT and convert output (complex numbers) to Magnitude
                Complex[] fftSpectrum = fft.Execute(scaledSpectrumChunk);
                double[] scaledFFTSpectrum = DSPLib.DSP.ConvertComplex.ToMagnitude(fftSpectrum);
                scaledFFTSpectrum = DSP.Math.Multiply(scaledFFTSpectrum, scaleFactor);

                // These 1024 magnitude values correspond (roughly) to a single point in the audio timeline
                float curSongTime = getTimeFromIndex(i) * spectrumSampleSize;

                // Send our magnitude data off to our Spectral Flux Analyzer to be analyzed for peaks
                SFAnalyser.analyseSpectrum(Array.ConvertAll(scaledFFTSpectrum, x => (float)x), curSongTime);
            }
        }

        public int getIndexFromTime(float curTime)
        {
            float lengthPerSample = timeInSeconds / (float)sampleCount;

            return (int)Math.Floor(curTime / lengthPerSample);
        }

        public float getTimeFromIndex(int index)
        {
            return ((1f / (float)this.sampleRate) * index);
        }
    }
}
