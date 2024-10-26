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
            player.namePlayer = "Melba";
            player.imgAnimal = Properties.Resources.dogStart;
            SetLabelAndImage();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            player.namePlayer = "Chuchi";
            player.imgAnimal = Properties.Resources.catlogo;
            SetLabelAndImage();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            player.namePlayer = "Pilochín";
            player.imgAnimal = Properties.Resources.piglogo;
            SetLabelAndImage();
        }

        private void SetLabelAndImage()
        {
            label5.Text = $"Animal seleccionado actualmente:  {player.namePlayer}";
            pictureBox4.Image = player.imgAnimal;
        }

    }
}
