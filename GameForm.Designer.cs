namespace CSC240_GameProject_jrm
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            gameLabel = new Label();
            guessTextBox = new TextBox();
            guessButton = new Button();
            bindingSource1 = new BindingSource(components);
            upArrowPictureBox = new PictureBox();
            downArrowPictureBox = new PictureBox();
            numGuessLabel = new Label();
            checkPictureBox = new PictureBox();
            replayButton = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upArrowPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)downArrowPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)checkPictureBox).BeginInit();
            SuspendLayout();
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.Font = new Font("Unispace", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gameLabel.Location = new Point(302, 74);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(489, 58);
            gameLabel.TabIndex = 0;
            gameLabel.Text = "Make your guess!";
            // 
            // guessTextBox
            // 
            guessTextBox.BackColor = Color.MediumSlateBlue;
            guessTextBox.Font = new Font("Unispace", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessTextBox.Location = new Point(392, 361);
            guessTextBox.Name = "guessTextBox";
            guessTextBox.Size = new Size(300, 51);
            guessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            guessButton.BackColor = Color.MediumSlateBlue;
            guessButton.Font = new Font("Unispace", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guessButton.Location = new Point(431, 458);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(225, 69);
            guessButton.TabIndex = 2;
            guessButton.Text = "Guess";
            guessButton.UseVisualStyleBackColor = false;
            guessButton.Click += GuessButton_Click;
            // 
            // upArrowPictureBox
            // 
            upArrowPictureBox.Image = (Image)resources.GetObject("upArrowPictureBox.Image");
            upArrowPictureBox.Location = new Point(30, 57);
            upArrowPictureBox.Name = "upArrowPictureBox";
            upArrowPictureBox.Size = new Size(248, 217);
            upArrowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            upArrowPictureBox.TabIndex = 4;
            upArrowPictureBox.TabStop = false;
            upArrowPictureBox.Visible = false;
            // 
            // downArrowPictureBox
            // 
            downArrowPictureBox.Image = (Image)resources.GetObject("downArrowPictureBox.Image");
            downArrowPictureBox.Location = new Point(30, 57);
            downArrowPictureBox.Name = "downArrowPictureBox";
            downArrowPictureBox.Size = new Size(248, 217);
            downArrowPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            downArrowPictureBox.TabIndex = 5;
            downArrowPictureBox.TabStop = false;
            downArrowPictureBox.Visible = false;
            // 
            // numGuessLabel
            // 
            numGuessLabel.AutoSize = true;
            numGuessLabel.Font = new Font("Unispace", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numGuessLabel.Location = new Point(800, 361);
            numGuessLabel.Name = "numGuessLabel";
            numGuessLabel.Size = new Size(217, 43);
            numGuessLabel.TabIndex = 6;
            numGuessLabel.Text = "0 Guesses";
            // 
            // checkPictureBox
            // 
            checkPictureBox.Image = (Image)resources.GetObject("checkPictureBox.Image");
            checkPictureBox.Location = new Point(30, 57);
            checkPictureBox.Name = "checkPictureBox";
            checkPictureBox.Size = new Size(248, 217);
            checkPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            checkPictureBox.TabIndex = 7;
            checkPictureBox.TabStop = false;
            checkPictureBox.Visible = false;
            // 
            // replayButton
            // 
            replayButton.Enabled = false;
            replayButton.Font = new Font("Unispace", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            replayButton.Location = new Point(402, 558);
            replayButton.Name = "replayButton";
            replayButton.Size = new Size(290, 69);
            replayButton.TabIndex = 8;
            replayButton.Text = "Play Again";
            replayButton.UseVisualStyleBackColor = false;
            replayButton.Click += ReplayButton_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1114, 716);
            Controls.Add(replayButton);
            Controls.Add(checkPictureBox);
            Controls.Add(numGuessLabel);
            Controls.Add(downArrowPictureBox);
            Controls.Add(upArrowPictureBox);
            Controls.Add(guessButton);
            Controls.Add(guessTextBox);
            Controls.Add(gameLabel);
            Name = "GameForm";
            Text = "Guess The Number";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)upArrowPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)downArrowPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)checkPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameLabel;
        private TextBox guessTextBox;
        private Button guessButton;
        private BindingSource bindingSource1;
        private PictureBox upArrowPictureBox;
        private PictureBox downArrowPictureBox;
        private Label numGuessLabel;
        private PictureBox checkPictureBox;
        private Button replayButton;
    }
}