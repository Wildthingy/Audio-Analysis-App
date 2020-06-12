using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Audio_Analysis_App
{

    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        internal AudioProcessor AudioProcessor
        {
            get => default(AudioProcessor);
            set
            {
            }
        }

        WaveOutEvent outputDevice;
        AudioFileReader song;
        string songPath;
        AudioProcessor audioProcessor;

        private void BrowseButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog songBrowser = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Select Song",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "wav",
                Filter = "Audio Files(*.wav;*.mp3;*.aiff;*)|*.wav;*.mp3;*.aiff;*|All Files(*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (songBrowser.ShowDialog() == DialogResult.OK)
            {
                songPath = songBrowser.FileName;
                SongName.Text = songBrowser.SafeFileName;
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (songPath != null)
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                    outputDevice.PlaybackStopped += OnPlaybackStopped;
                }
                if (song == null)
                {
                    song = new AudioFileReader(songPath);
                    outputDevice.Init(song);
                }
                outputDevice.Play();
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            song.Dispose();
            song = null;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (songPath != null)
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                }

                if (song == null)
                {
                    song = new AudioFileReader(songPath);
                    outputDevice.Init(song);
                }

                audioProcessor = new AudioProcessor(song);

                dataDisplay.Series[0].Points.DataBindXY(GlobalVariables.times, GlobalVariables.thresholds);
                dataDisplay.Series[1].Points.DataBindXY(GlobalVariables.times, GlobalVariables.prunedSFValues);
                dataDisplay.Series[2].Points.DataBindXY(GlobalVariables.times, GlobalVariables.beats);
                dataDisplay.Series[3].Points.DataBindXY(GlobalVariables.times, GlobalVariables.intensityLevel);
                dataDisplay.Size = new Size(50 * (int)song.TotalTime.TotalSeconds, 282);

                float n;
                if (float.TryParse(bpmEntry.Text, out n))
                    GlobalVariables.bpm = n;
                else
                {
                    GlobalVariables.bpm = GlobalVariables.numBeats / (float)song.TotalTime.TotalMinutes;
                }
                    

                string songName = songNameEntry.Text;
                string artistName = artistNameEntry.Text;
                string filename = songName + " - Audio Data.json";

                Output output = new Output();
                output.outputData(songName, artistName, filename);
            }
        }
    }
}
