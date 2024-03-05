using System.Security.Cryptography.X509Certificates;

namespace CSC240_GameProject_jrm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            ConstValue.usrdf = difficultyTrackBar.Value;
            GameForm gameForm = new GameForm();
            gameForm.ShowDialog();
        }
    }
    public static class ConstValue
    {
        public static int usrdf { get; set; }
    }

}
