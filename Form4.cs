using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameQuest
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonSecretly_Click(object sender, EventArgs e)
        {
            Close();
            Game.You_Lose_Archer();

        }

        private void buttonKnight_Click(object sender, EventArgs e)
        {
            Close();
            Game.Thief_Win_Archer();

        }
    }
}
