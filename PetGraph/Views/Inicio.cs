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
        private readonly Timer timer = new Timer();
        private readonly int speed = 5;

        public Inicio()
        {
            InitializeComponent();
            if (player.namePlayer == null)
            {
                player.namePlayer = "Melba";
                player.imgAnimal = Properties.Resources.dogStart;
            }
            ReproductorSonidos.ReproducirMusica("title-theme.mp3");
            ReproductorSonidos.EstablecerVolumen();
            ConfiguracionTemas.EstablecerTema(this);
            pictureBox2.SendToBack();
            timer.Interval = 100;
            timer.Tick += (s, e) =>
            {
                if (pictureBox2.Location.X + pictureBox2.Width < this.Width + 70)
                    pictureBox2.Location = new Point(pictureBox2.Location.X + speed, pictureBox2.Location.Y);
                else
                    pictureBox2.Location = new Point(-100, pictureBox2.Location.Y);
            };
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            ConfiguracionTemas.EstablecerLogoTema(pictureBox1);  
            ConfiguracionTemas.EstablecerTema(this , true, pictureBox3); 
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            ReproductorSonidos.ReproducirSonido("menu-move.mp3");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            MascotasForm mascotasForm = new MascotasForm(player);
            ConfiguracionTemas.EstablecerTema(mascotasForm);
            mascotasForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            Alerta.Show();
 
            GraphForm graphForm = new GraphForm(player);
            ConfiguracionTemas.EstablecerTema(graphForm);
            this.Hide();
            graphForm.FormClosing += (s, ev) => 
            {
                this.Show();
                ReproductorSonidos.ReproducirMusica("title-theme.mp3");
            };
            graphForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            panel1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            panel1.Visible = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ReproductorSonidos.EstablecerVolumen((float)trackBar1.Value / 10f);
        }
    }
}