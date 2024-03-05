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
            int rndNum = rnd.Next(1, ConstValue.usrdf);
        }
    }
}
