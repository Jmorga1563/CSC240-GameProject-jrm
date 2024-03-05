using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_GameProject_jrm
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            ConstValue.RndNum = rnd.Next(0, ConstValue.Usrdf);
            ConstValue.Numguess = 0;
            ConstValue.Rounds += 1;
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            ConstValue.Numguess += 1;
            ConstValue.Totalguess += 1;
            numGuessLabel.Text = "Guesses: " + ConstValue.Numguess;
            upArrowPictureBox.Visible = false;
            downArrowPictureBox.Visible = false;
            int usrGuess = Convert.ToInt32(guessTextBox.Text);
            if (usrGuess > ConstValue.RndNum)
            {
                downArrowPictureBox.Visible = true;
                gameLabel.Text = "Too High! Guess Lower";

            }
            else if (usrGuess < ConstValue.RndNum)
            {
                upArrowPictureBox.Visible = true;
                gameLabel.Text = "Too Low! Guess Higher";
            }
            else if (usrGuess == ConstValue.RndNum)
            {
                guessButton.Enabled = false;
                checkPictureBox.Visible = true;
                gameLabel.Text = "You got it!\nIt only took " + ConstValue.Numguess + " guesses!\nClick play again to \nplay again!";
                replayButton.Enabled = true;
            }
        }

        private void ReplayButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new();
            main.ShowDialog();
            this.Close();
        }
    }
}
