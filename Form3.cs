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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonKnight_Click(object sender, EventArgs e)
        {
            Close();
            Game.You_Lose_Knight();

        }

        private void buttonSecretly_Click(object sender, EventArgs e)
        {
Close();
            Game.You_Win_Knight();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
