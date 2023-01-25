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
    public partial class Thief : Form
    {
        public Thief()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonKnight_Click(object sender, EventArgs e)
        {
            Game.Quest();
            Form form= new Form();
            form.Close();

        }
    }
}
