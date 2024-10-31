using PetGraphBackend.Configs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGraph.Views
{
    public partial class Alerta : Form
    {
        public Alerta()
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
        }

        public Alerta(string msg, string msgButton)
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
            label3.Text = msg;
            button2.Text = msgButton;
        }

        public static void Show()
        {
            new Alerta().ShowDialog();
        }

        public static void Show(string msg, string msgButton, string title = "¡Hey, espera un segundo!")
        {
            Alerta alerta = new Alerta(msg, msgButton);

            if (title == "correcto")
            {
                title = "¡Felicidades!";
                alerta.pictureBox1.Image = Properties.Resources.checkIcon;
            }
            else if (title == "erroneo")
            {
                title = "¡Uy! Parece que te has equivocado...";
                alerta.pictureBox1.Image = Properties.Resources.crossIcon;
            }
            else if (title == "derrota")
            {
                title = "¡Que mal! Has perdido";
                alerta.pictureBox1.Image = Properties.Resources.piglogo;
            }

            alerta.Text = title;
            alerta.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            Close();
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
    }
}
