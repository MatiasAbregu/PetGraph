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
    public partial class MascotasForm : Form
    {
        private Player player;
        private int personajesSlider = 0;

        public MascotasForm(Player player)
        {
            InitializeComponent();
            pictureBox1.BringToFront();
            this.player = player;
            SetLabelAndImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            this.Close();
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.BackgroundImage = null;
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-move.mp3");
            Cursor = Cursors.Hand;
            if (sender is PictureBox)
            {
                PictureBox pictureBox = sender as PictureBox;
                if (pictureBox.Name.Equals("pictureBox1"))
                {
                    pictureBox.BackgroundImage = Properties.Resources.melbaBackground;
                }
                else if (pictureBox.Name.Equals("pictureBox2"))
                {
                    pictureBox.BackgroundImage = Properties.Resources.chuchiBackground;
                }
                else if (pictureBox.Name.Equals("pictureBox3"))
                {
                    pictureBox.BackgroundImage = Properties.Resources.picholinBackground;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            if(label1.Text != "???")
            {
                player.namePlayer = label1.Text;
                player.imgAnimal = pictureBox1.Image;
            }
            SetLabelAndImage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            if(label2.Text != "???")
            {
                player.namePlayer = label2.Text;
                player.imgAnimal = pictureBox2.Image;
            }
            SetLabelAndImage();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            if(label3.Text != "???")
            {
                player.namePlayer = label3.Text;
                player.imgAnimal = pictureBox3.Image;
            }
            SetLabelAndImage();
        }


        private void SetLabelAndImage()
        {
            label5.Text = $"Animal seleccionado actualmente:  {player.namePlayer}";
            pictureBox4.Image = player.imgAnimal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personajesSlider = personajesSlider == 1 ? 0 : personajesSlider + 1;
            ActualizarMascotas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personajesSlider = personajesSlider == 0 ? 1 : personajesSlider - 1;
            ActualizarMascotas();
        }

        private void ActualizarMascotas()
        {
            if (personajesSlider == 0)
            {
                label1.Text = "Melba";
                pictureBox1.Image = Properties.Resources.dogStart;

                label2.Text = "Chuchi";
                pictureBox2.Image = Properties.Resources.catlogo;

                label3.Text = "Pilochín";
                pictureBox3.Image = Properties.Resources.piglogo;
            }
            else if (personajesSlider == 1)
            {
                label1.Text = "Dana";
                pictureBox1.Image = Properties.Resources.dana;

                label2.Text = "???";
                pictureBox2.Image = null;

                label3.Text = "???";
                pictureBox3.Image = null;
            }
        }
    }
}
