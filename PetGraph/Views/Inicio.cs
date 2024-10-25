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
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConfiguracionTemas.EstablecerLogoTema(pictureBox1);  
            ConfiguracionTemas.EstablecerTema(this , true); 
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MascotasForm mascotasForm = new MascotasForm();
            ConfiguracionTemas.EstablecerTema(mascotasForm);
            mascotasForm.Show();
        }
    }
}