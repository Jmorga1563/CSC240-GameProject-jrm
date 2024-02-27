namespace CSC240_GameProject_jrm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            promptLabel = new Label();
            difficultyTrackBar = new TrackBar();
            trackLabel = new Label();
            goButton = new Button();
            ((System.ComponentModel.ISupportInitialize)difficultyTrackBar).BeginInit();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            promptLabel.Location = new Point(90, 79);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(953, 116);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Select your difficulty and press\r\ngo to test your deduction!\r\n";
            // 
            // difficultyTrackBar
            // 
            difficultyTrackBar.AccessibleName = "";
            difficultyTrackBar.BackColor = Color.Navy;
            difficultyTrackBar.Location = new Point(567, 328);
            difficultyTrackBar.Maximum = 101;
            difficultyTrackBar.Minimum = 1;
            difficultyTrackBar.Name = "difficultyTrackBar";
            difficultyTrackBar.RightToLeft = RightToLeft.No;
            difficultyTrackBar.Size = new Size(533, 136);
            difficultyTrackBar.TabIndex = 1;
            difficultyTrackBar.Tag = "";
            difficultyTrackBar.TickFrequency = 10;
            difficultyTrackBar.TickStyle = TickStyle.Both;
            difficultyTrackBar.Value = 1;
            // 
            // trackLabel
            // 
            trackLabel.AutoSize = true;
            trackLabel.Font = new Font("Unispace", 7.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            trackLabel.Location = new Point(39, 294);
            trackLabel.Name = "trackLabel";
            trackLabel.Size = new Size(497, 234);
            trackLabel.TabIndex = 2;
            trackLabel.Text = "First tick selects a \r\nnumber between  0 and 1 \r\neach tick increases the \r\nupper limit by 10.\r\nMaximum difficulty is \r\nbetween 0 and 101.";
            // 
            // goButton
            // 
            goButton.BackColor = Color.MediumSlateBlue;
            goButton.Font = new Font("Unispace", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goButton.ForeColor = SystemColors.ControlText;
            goButton.Location = new Point(710, 559);
            goButton.Name = "goButton";
            goButton.Size = new Size(225, 69);
            goButton.TabIndex = 3;
            goButton.Text = "Go!";
            goButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1192, 736);
            Controls.Add(goButton);
            Controls.Add(trackLabel);
            Controls.Add(difficultyTrackBar);
            Controls.Add(promptLabel);
            Name = "MainForm";
            Text = "Guess The Number";
            ((System.ComponentModel.ISupportInitialize)difficultyTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label promptLabel;
        private TrackBar difficultyTrackBar;
        private Label trackLabel;
        private Button goButton;
    }
}
