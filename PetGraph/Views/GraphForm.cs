using PetGraphBackend.Configs;
using PetGraphBackend.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGraph.Views
{
    public partial class GraphForm : Form
    {
        private Player player;
        private string formula;
        public GraphForm(Player player)
        {
            InitializeComponent();
            this.player = player;
            ReproductorSonidos.ReproducirMusica("graph-theme.mp3");
            pictureBox1.Image = player.imgAnimal;
        }

        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Width: 900; Height: 750 (FORMULARIO)

            // Lapiz color y trazo
            Pen pen = new Pen(ConfiguracionTemas.ObtenerColorParaGrafica(), 3);

            // Eje de Ordenadas
            int Ox1 = 455;
            int Oy1 = 20;
            int Oy2 = 690;
            Point startPoint = new Point(Ox1, Oy1);
            Point endPoint = new Point(Ox1, Oy2);
            g.DrawLine(pen, startPoint, endPoint);

            // Puntas FLECHAS
            Point[] puntaSuperior = { new Point(Ox1, Oy1 - 2),
                new Point(Ox1 - 10, Oy1 + 15), new Point(Ox1 + 10, Oy1 + 15) };
            g.FillPolygon(new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()), puntaSuperior);

            Point[] puntaInferior = { new Point(Ox1, Oy2 + 2),
                new Point(Ox1 - 10, Oy2 - 15), new Point(Ox1 + 10, Oy2 - 15) };
            g.FillPolygon(new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()), puntaInferior);

            // Eje de Abscisas
            int Ax1 = 40;
            int Ax2 = 850;
            int Ay1 = 355;
            Point startPoint2 = new Point(Ax1, Ay1);
            Point endPoint2 = new Point(Ax2, Ay1);
            g.DrawLine(pen, startPoint2, endPoint2);
            g.DrawLine(pen, startPoint2, endPoint2);

            // Puntas FLECHAS
            Point[] puntaDerecha = { new Point(Ax2 + 2, Ay1),
                new Point(Ax2 - 15, Ay1 - 10), new Point(Ax2 - 15, Ay1 + 10) };
            g.FillPolygon(new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()), puntaDerecha);

            Point[] puntaIzquierda = { new Point(Ax1 - 2, Ay1),
                new Point(Ax1 + 15, Ay1 - 10), new Point(Ax1 + 15, Ay1 + 10) };
            g.FillPolygon(new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()), puntaIzquierda);

            // DIBUJAR LINEAS EN LOS EJES DONDE SE COLOCARAN PUNTOS

            // Liberar los recursos
            pen.Dispose();
        }

        private void RandomizarFuncion()
        {
            Random randomizador = new Random();
            int cantTerminos = randomizador.Next(1, 4);
            formula = "";

            if (cantTerminos == 1) // X o Y
            {
                formula = randomizador.Next(1, 3) == 1 ? "x = " : "y = ";
                formula += $"{randomizador.Next(1, 20)}";
            } else if(cantTerminos == 2) // X +- Y =
            {
                formula = randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(1, 10)}x" : "x";
                formula += randomizador.Next(1, 3) == 1 ? " + " : " - ";
                if(Regex.IsMatch(formula, @"\d"))
                {
                    formula += $"{randomizador.Next(1, 10)}y";
                } else
                {
                    formula += randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(1, 10)}y" : "y";
                }
            } else if(cantTerminos == 3) // X +- N = Y || Y +- N = X
            {
                formula = randomizador.Next(1, 3) == 1 ? "x" : "y";
                if(formula == "x")
                {

                } else
                {

                }
            }

            MessageBox.Show(formula);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RandomizarFuncion();
        }
    }
}
