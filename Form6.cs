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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Game.Killing_Mag();
        }

        private void buttonKnight1_Click(object sender, EventArgs e)
        {
            Close();
            Game.Black_Orden();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Game.Money_Mag();
        }
    }
}
