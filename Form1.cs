using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace CSC240_GameProject_jrm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            totalGuessLabel.Text = "Total Guesses: " + ConstValue.Totalguess;
            roundsLabel.Text = "Rounds Played: " + ConstValue.Rounds;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            ConstValue.Usrdf = difficultyTrackBar.Value;
            this.Hide();
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
            this.Close();
        }
    }
    public static class ConstValue
    {
        public static int Usrdf { get; set; }
        public static int RndNum { get; set; }
        public static int Numguess { get; set; }
        public static int Totalguess { get; set; }
        public static int Rounds { get; set; }
    }

}
