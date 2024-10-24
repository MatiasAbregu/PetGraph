using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGraph
{
    public partial class Form1 : Form
    {
        private bool tema = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tema)
            {
                pictureBox1.Image = Properties.Resources.moongif;
                this.BackColor = Color.White;
                tema = false;

                label1.ForeColor = Color.FromArgb(30, 30, 30);
                label2.ForeColor = Color.FromArgb(30, 30, 30);
            } else
            {
                pictureBox1.Image = Properties.Resources.sungif;
                this.BackColor = Color.FromArgb(30,30,30);
                tema = true;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
        }
    }
}
