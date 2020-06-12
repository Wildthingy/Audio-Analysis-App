namespace BeatSaberMapMaker
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
            this.button1 = new System.Windows.Forms.Button();
            this.FilenameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.outputDisplay = new System.Windows.Forms.RichTextBox();
            this.inputDisplay = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.difficultySelect = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MapperName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heightSelect = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alignSelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.directionSelect = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.handSelect = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browse_Click);
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Location = new System.Drawing.Point(12, 9);
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(179, 13);
            this.FilenameLabel.TabIndex = 1;
            this.FilenameLabel.Text = "Click browse to select audio data file";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.process_Click);
            // 
            // outputDisplay
            // 
            this.outputDisplay.Location = new System.Drawing.Point(508, 25);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(280, 413);
            this.outputDisplay.TabIndex = 5;
            this.outputDisplay.Text = "";
            // 
            // inputDisplay
            // 
            this.inputDisplay.Location = new System.Drawing.Point(222, 25);
            this.inputDisplay.Name = "inputDisplay";
            this.inputDisplay.Size = new System.Drawing.Size(280, 413);
            this.inputDisplay.TabIndex = 6;
            this.inputDisplay.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.handSelect);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.directionSelect);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.alignSelect);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.heightSelect);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.difficultySelect);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Version);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MapperName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 383);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // difficultySelect
            // 
            this.difficultySelect.FormattingEnabled = true;
            this.difficultySelect.Items.AddRange(new object[] {
            "Normal",
            "Hard",
            "Expert"});
            this.difficultySelect.Location = new System.Drawing.Point(87, 71);
            this.difficultySelect.Name = "difficultySelect";
            this.difficultySelect.Size = new System.Drawing.Size(107, 21);
            this.difficultySelect.TabIndex = 8;
            this.difficultySelect.Text = "Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Difficulty";
            // 
            // Version
            // 
            this.Version.Location = new System.Drawing.Point(87, 46);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(107, 20);
            this.Version.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Version";
            // 
            // MapperName
            // 
            this.MapperName.Location = new System.Drawing.Point(87, 20);
            this.MapperName.Name = "MapperName";
            this.MapperName.Size = new System.Drawing.Size(107, 20);
            this.MapperName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mapper Name";
            // 
            // heightSelect
            // 
            this.heightSelect.FormattingEnabled = true;
            this.heightSelect.Items.AddRange(new object[] {
            "Low",
            "Middle",
            "High",
            "Cycle"});
            this.heightSelect.Location = new System.Drawing.Point(87, 98);
            this.heightSelect.Name = "heightSelect";
            this.heightSelect.Size = new System.Drawing.Size(107, 21);
            this.heightSelect.TabIndex = 10;
            this.heightSelect.Text = "Select";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Note Height";
            // 
            // alignSelect
            // 
            this.alignSelect.FormattingEnabled = true;
            this.alignSelect.Items.AddRange(new object[] {
            "Left Outer",
            "Left Inner",
            "Right Inner",
            "Right Outer",
            "Cycle"});
            this.alignSelect.Location = new System.Drawing.Point(87, 125);
            this.alignSelect.Name = "alignSelect";
            this.alignSelect.Size = new System.Drawing.Size(107, 21);
            this.alignSelect.TabIndex = 12;
            this.alignSelect.Text = "Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Note Alignment";
            // 
            // directionSelect
            // 
            this.directionSelect.FormattingEnabled = true;
            this.directionSelect.Items.AddRange(new object[] {
            "Up Left",
            "Up",
            "Up Right",
            "Left",
            "Any",
            "Right",
            "Down Left",
            "Down",
            "Down Right",
            "Cycle"});
            this.directionSelect.Location = new System.Drawing.Point(87, 152);
            this.directionSelect.Name = "directionSelect";
            this.directionSelect.Size = new System.Drawing.Size(107, 21);
            this.directionSelect.TabIndex = 14;
            this.directionSelect.Text = "Select";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cut Direction";
            // 
            // handSelect
            // 
            this.handSelect.FormattingEnabled = true;
            this.handSelect.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Alternate"});
            this.handSelect.Location = new System.Drawing.Point(87, 179);
            this.handSelect.Name = "handSelect";
            this.handSelect.Size = new System.Drawing.Size(107, 21);
            this.handSelect.TabIndex = 16;
            this.handSelect.Text = "Select";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hand Use";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(97, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.save_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 325);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(191, 23);
            this.progressBar.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputDisplay);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FilenameLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label FilenameLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox outputDisplay;
        private System.Windows.Forms.RichTextBox inputDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Version;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MapperName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox difficultySelect;
        private System.Windows.Forms.ComboBox handSelect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox directionSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox alignSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox heightSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button3;
    }
}

