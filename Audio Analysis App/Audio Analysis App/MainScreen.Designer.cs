namespace Audio_Analysis_App
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PlayButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SongName = new System.Windows.Forms.Label();
            this.SongProgress = new System.Windows.Forms.ProgressBar();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.songNameEntry = new System.Windows.Forms.TextBox();
            this.songNameEntryLabel = new System.Windows.Forms.Label();
            this.artistNameEntry = new System.Windows.Forms.TextBox();
            this.artistNameEntryLabel = new System.Windows.Forms.Label();
            this.bpmEntry = new System.Windows.Forms.TextBox();
            this.bpmEntryLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataDisplay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(84, 45);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(165, 45);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SongName);
            this.flowLayoutPanel1.Controls.Add(this.SongProgress);
            this.flowLayoutPanel1.Controls.Add(this.BrowseButton);
            this.flowLayoutPanel1.Controls.Add(this.PlayButton);
            this.flowLayoutPanel1.Controls.Add(this.StopButton);
            this.flowLayoutPanel1.Controls.Add(this.ProcessButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 56);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(332, 76);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Location = new System.Drawing.Point(3, 0);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(147, 13);
            this.SongName.TabIndex = 5;
            this.SongName.Text = "Press \'Browse\' to select song.";
            // 
            // SongProgress
            // 
            this.SongProgress.Location = new System.Drawing.Point(3, 16);
            this.SongProgress.Name = "SongProgress";
            this.SongProgress.Size = new System.Drawing.Size(318, 23);
            this.SongProgress.Step = 1;
            this.SongProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SongProgress.TabIndex = 3;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(3, 45);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click_1);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(246, 45);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(75, 23);
            this.ProcessButton.TabIndex = 6;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Audio Analysis Application";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.songNameEntry);
            this.flowLayoutPanel2.Controls.Add(this.songNameEntryLabel);
            this.flowLayoutPanel2.Controls.Add(this.artistNameEntry);
            this.flowLayoutPanel2.Controls.Add(this.artistNameEntryLabel);
            this.flowLayoutPanel2.Controls.Add(this.bpmEntry);
            this.flowLayoutPanel2.Controls.Add(this.bpmEntryLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(350, 56);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(216, 76);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // songNameEntry
            // 
            this.songNameEntry.Location = new System.Drawing.Point(3, 3);
            this.songNameEntry.Name = "songNameEntry";
            this.songNameEntry.Size = new System.Drawing.Size(141, 20);
            this.songNameEntry.TabIndex = 0;
            // 
            // songNameEntryLabel
            // 
            this.songNameEntryLabel.AutoSize = true;
            this.songNameEntryLabel.Location = new System.Drawing.Point(150, 0);
            this.songNameEntryLabel.Name = "songNameEntryLabel";
            this.songNameEntryLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.songNameEntryLabel.Size = new System.Drawing.Size(32, 18);
            this.songNameEntryLabel.TabIndex = 3;
            this.songNameEntryLabel.Text = "Song";
            // 
            // artistNameEntry
            // 
            this.artistNameEntry.Location = new System.Drawing.Point(3, 29);
            this.artistNameEntry.Name = "artistNameEntry";
            this.artistNameEntry.Size = new System.Drawing.Size(141, 20);
            this.artistNameEntry.TabIndex = 1;
            // 
            // artistNameEntryLabel
            // 
            this.artistNameEntryLabel.AutoSize = true;
            this.artistNameEntryLabel.Location = new System.Drawing.Point(150, 26);
            this.artistNameEntryLabel.Name = "artistNameEntryLabel";
            this.artistNameEntryLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.artistNameEntryLabel.Size = new System.Drawing.Size(30, 18);
            this.artistNameEntryLabel.TabIndex = 4;
            this.artistNameEntryLabel.Text = "Artist";
            // 
            // bpmEntry
            // 
            this.bpmEntry.Location = new System.Drawing.Point(3, 55);
            this.bpmEntry.Name = "bpmEntry";
            this.bpmEntry.Size = new System.Drawing.Size(141, 20);
            this.bpmEntry.TabIndex = 2;
            this.bpmEntry.Text = "Leave if unknown";
            // 
            // bpmEntryLabel
            // 
            this.bpmEntryLabel.AutoSize = true;
            this.bpmEntryLabel.Location = new System.Drawing.Point(150, 52);
            this.bpmEntryLabel.Name = "bpmEntryLabel";
            this.bpmEntryLabel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bpmEntryLabel.Size = new System.Drawing.Size(30, 18);
            this.bpmEntryLabel.TabIndex = 5;
            this.bpmEntryLabel.Text = "BPM";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.textBox4);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.textBox5);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.textBox6);
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(572, 56);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(216, 76);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(3, 29);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 26);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(141, 20);
            this.textBox6.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 52);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Size = new System.Drawing.Size(35, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(633, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Recorded BPM:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataDisplay);
            this.panel1.Location = new System.Drawing.Point(12, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 300);
            this.panel1.TabIndex = 11;
            // 
            // dataDisplay
            // 
            chartArea1.Name = "ChartArea1";
            this.dataDisplay.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.dataDisplay.Legends.Add(legend1);
            this.dataDisplay.Location = new System.Drawing.Point(0, 0);
            this.dataDisplay.MaximumSize = new System.Drawing.Size(0, 294);
            this.dataDisplay.MinimumSize = new System.Drawing.Size(776, 0);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Chartreuse;
            series1.Legend = "Legend1";
            series1.Name = "Beat Threshold";
            series1.XValueMember = "5";
            series1.YValueMembers = "10";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Purple;
            series2.Legend = "Legend1";
            series2.Name = "Spectral Flux";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Detected Beats";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series4.Color = System.Drawing.Color.Blue;
            series4.Legend = "Legend1";
            series4.Name = "IntensityLevel";
            this.dataDisplay.Series.Add(series1);
            this.dataDisplay.Series.Add(series2);
            this.dataDisplay.Series.Add(series3);
            this.dataDisplay.Series.Add(series4);
            this.dataDisplay.Size = new System.Drawing.Size(776, 282);
            this.dataDisplay.TabIndex = 10;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainScreen";
            this.Text = "Audio Analysis App";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar SongProgress;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox songNameEntry;
        private System.Windows.Forms.Label songNameEntryLabel;
        private System.Windows.Forms.TextBox artistNameEntry;
        private System.Windows.Forms.Label artistNameEntryLabel;
        private System.Windows.Forms.TextBox bpmEntry;
        private System.Windows.Forms.Label bpmEntryLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataDisplay;
    }
}

