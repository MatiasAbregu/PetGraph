using PetGraph.Views;
using PetGraphBackend.Configs;
using PetGraphBackend.Objetos;
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

        private Player player = new Player();

        public Inicio()
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.reproducirSonido("menu-select.mp3");
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
            ReproductorSonidos.reproducirSonido("menu-move.mp3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.reproducirSonido("menu-select.mp3");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.reproducirSonido("menu-select.mp3");
            MascotasForm mascotasForm = new MascotasForm(player);
            ConfiguracionTemas.EstablecerTema(mascotasForm);
            mascotasForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.reproducirSonido("menu-select.mp3");
            GraphForm graphForm = new GraphForm();
            ConfiguracionTemas.EstablecerTema(graphForm);
            Hide();
            graphForm.FormClosing += (s, ev) => this.Show();
            graphForm.Show();
        }
    }
}