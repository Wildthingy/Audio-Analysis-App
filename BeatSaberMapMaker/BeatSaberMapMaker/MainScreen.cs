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
using Newtonsoft.Json;

namespace BeatSaberMapMaker
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        internal infoOutput infoOutput1
        {
            get => default(infoOutput);
            set
            {
            }
        }

        internal beatmapOutput beatmapOutput1
        {
            get => default(beatmapOutput);
            set
            {
            }
        }

        input input;
        infoOutput infoOutput;
        beatmapOutput beatmapOutput;
        int height, alignment, direction, hand;

        private void save_Click(object sender, EventArgs e)
        {
            string difficulty = difficultySelect.SelectedItem.ToString();
            beatmapOutput.output(difficulty);
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dataBrowser = new OpenFileDialog
            {
                InitialDirectory = @"",
                Title = "Select Data File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "Text Files(*.txt;*.json;*)|*.txt;*.json;*|All Files(*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (dataBrowser.ShowDialog() == DialogResult.OK)
            {
                string jsonInput = File.ReadAllText(dataBrowser.FileName);

                inputDisplay.Text = jsonInput;

                FilenameLabel.Text = dataBrowser.SafeFileName;
                input = JsonConvert.DeserializeObject<input>(jsonInput);
                
            }
        }

        private void process_Click(object sender, EventArgs e)
        {
            height = heightSelect.SelectedIndex;
            alignment = alignSelect.SelectedIndex;
            direction = directionSelect.SelectedIndex;
            hand = handSelect.SelectedIndex;
            process();
        }

        private void process()
        {
            infoOutput = new infoOutput();
            beatmapOutput = new beatmapOutput(Version.Text, input.beats.Count);
            int prevHeight = 0;
            int prevAlignment = 0;
            int prevCutDir = 0;
            int prevHand = 0;
            int numBeats = input.beats.Count;

            for (int i = 0; i < numBeats; i++)
            {
                beatmapOutput._notes[i]._time = input.beats[i];

                if (height == 3)
                {
                    beatmapOutput._notes[i]._lineLayer = prevHeight + 1;
                    ++prevHeight;
                    if (prevHeight == 2)
                        prevHeight = -1;
                }
                else
                    beatmapOutput._notes[i]._lineLayer = height;

                if (alignment == 4)
                {
                    beatmapOutput._notes[i]._lineIndex = prevAlignment + 1;
                    ++prevAlignment;
                    if (prevAlignment == 3)
                        prevAlignment = -1;
                }
                else
                    beatmapOutput._notes[i]._lineIndex = alignment;

                if (direction == 9)
                {
                    beatmapOutput._notes[i]._cutDirection = prevCutDir + 1;
                    ++prevCutDir;
                    if (prevCutDir == 8)
                        prevCutDir = -1;
                }
                else
                    beatmapOutput._notes[i]._cutDirection = direction;

                if (hand == 2)
                {
                    beatmapOutput._notes[i]._type = prevHand + 1;
                    ++prevHand;
                    if (prevHand == 1)
                        prevHand = -1;
                }
                else
                    beatmapOutput._notes[i]._type = hand;

                progressBar.Value = i / numBeats * 100;
            }

            progressBar.Value = 100;

            outputDisplay.Text = JsonConvert.SerializeObject(beatmapOutput, Formatting.Indented);
        }
    }
}
