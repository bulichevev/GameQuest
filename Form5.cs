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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonKnight1_Click(object sender, EventArgs e)
        {
            Close();
            Game.Talking_Mag();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Game.Killing_Mag();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
