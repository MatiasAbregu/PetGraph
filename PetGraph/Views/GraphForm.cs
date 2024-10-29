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
        private string formula;
        private bool teclaPresionadaR = false, teclaPresionadaL = false,
            teclaPresionadaU = false, teclaPresionadaD = false, teclaPresionadaEnter = false;
        private int playerX = 5, playerY = 4; // hasta 9 que es longitud de vector
        private int numeroLabel = 0, zoomX = 0, zoomY = 0;

        public GraphForm(Player player)
        {
            InitializeComponent();
            ReproductorSonidos.ReproducirMusica("graph-theme.mp3");
            pictureBox1.Image = player.imgAnimal;
            Text = $"PetGraph - ¡Juega con {player.namePlayer}!";
            panel1.Location = new Point(445 - 30, 355 - 35);
            label2.Text = $"({obtenerNumerosX()[playerX]}, {obtenerNumerosY()[playerY]})";
        }

        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Width: 900; Height: 750 (FORMULARIO)

            // Lapiz color y trazo
            Pen pen = new Pen(ConfiguracionTemas.ObtenerColorParaGrafica(), 3);

            // Eje de Ordenadas
            int Ox1 = 445;
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

            // DIBUJAR LINEAS Y NÚMEROS EN LOS EJES DONDE SE COLOCARAN PUNTOS
            int inicioX = 70;
            double[] numeroXPositivos = obtenerNumerosX().Where(n => n > 0).ToArray();
            double[] numeroXNegativos = obtenerNumerosX().Where(n => n < 0).ToArray();

            // FRAN HACE ESTO, NECESTIO QUE ACOMODES POR LONGITUD DE TEXTO O POR NUMEROS EL TEXTO, QUE
            // QUEDE LO ´MÁS PAREJO POSIBLE
            // La parte de   new Point(Ox1 - (70 * (5 - lineas)) - 14, 375)); es donde se modifica la long
            for (int lineas = 0; lineas < 5; lineas++)
            {
                g.DrawLine(pen, new Point(Ox1 - inicioX, 345), new Point(Ox1 - inicioX, 365));
                g.DrawString(numeroXNegativos[lineas].ToString(), new Font("Bahnschrift Condensed", 15),
                    new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()),
                    new Point(Ox1 - (70 * (5 - lineas)) - 14, 375));

                g.DrawLine(pen, new Point(Ox1 + inicioX, 345), new Point(Ox1 + inicioX, 365));
                g.DrawString(numeroXPositivos[lineas].ToString(), new Font("Bahnschrift Condensed", 15),
                    new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()),
                    new Point(Ox1 + inicioX - 6, 375));
                inicioX += 70;
            }

            int inicioY = 70;
            double[] numeroYPositivos = obtenerNumerosY().Where(n => n > 0).ToArray();
            double[] numeroYNegativos = obtenerNumerosY().Where(n => n < 0).ToArray();
            for (int lineas = 0; lineas < 4; lineas++)
            {
                g.DrawLine(pen, new Point(Ox1 - 13, Ay1 - inicioY), new Point(Ox1 + 13, Ay1 - inicioY));
                g.DrawString(numeroYPositivos[lineas].ToString(), new Font("Bahnschrift Condensed", 15),
                    new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()),
                    new Point(numeroYPositivos[lineas] > 9
                    ? Ox1 - 35 : Ox1 - 30, Ay1 - inicioY - 10));

                g.DrawLine(pen, new Point(Ox1 - 13, Ay1 + inicioY), new Point(Ox1 + 13, Ay1 + inicioY));
                g.DrawString(numeroYNegativos[lineas].ToString(), new Font("Bahnschrift Condensed", 15),
                    new SolidBrush(ConfiguracionTemas.ObtenerColorParaGrafica()),
                    new Point(numeroYNegativos[lineas] < -9 ? Ox1 - 43 : Ox1 - 40,
                    Ay1 + (70 * (4 - lineas)) - 10));
                inicioY += 70;
            }

            pen.Dispose();
        }

        private void RandomizarPuntos()
        {
            Random randomizador = new Random();
            int cantPuntos = randomizador.Next(1, 6);
            List<string> puntos = new List<string>();

            for (int i = 0; i < cantPuntos; i++)
            {
                int x = randomizador.Next(-10, 10);
                int y = randomizador.Next(-10, 10);
                puntos.Add($"({x}, {y})");
            }

            formula = string.Join("; ", puntos);

            MessageBox.Show(formula);
        }

        private void RandomizarFuncion()
        {
            Random randomizador = new Random();
            int cantTerminos = randomizador.Next(1, 4);
            formula = "";

            if (cantTerminos == 1) // X o Y
            {
                formula = randomizador.Next(1, 3) == 1 ? "x = " : "y = ";
                formula += $"{randomizador.Next(-10, 10)}";
            }
            else if (cantTerminos == 2) // X +- Y =
            {
                do
                {
                    formula = randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(-10, 10)}x" : "x";
                    formula += randomizador.Next(1, 3) == 1 ? " + " : " - ";
                    formula += randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(-10, 10)}y" : "y";
                } while (formula == "x - y" || formula == "x + y");
            }
            else if (cantTerminos == 3) // X +- N = Y || Y +- N = X
            {
                formula = randomizador.Next(1, 3) == 1 ? "x" : "y";
                if (formula == "x")
                {
                    formula = randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(-10, 10)}x" : "x";
                    formula += randomizador.Next(1, 3) == 1
                    ? $" + {randomizador.Next(-10, 10)} = " : $" - {randomizador.Next(-10, 10)} = ";
                    formula += randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(-10, 10)}y" : "y";
                }
                else
                {
                    formula = randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(-10, 10)}y" : "y";
                    formula += randomizador.Next(1, 3) == 1
                    ? $" + {randomizador.Next(-10, 10)} = " : $" - {randomizador.Next(-10, 10)} = ";
                    formula += randomizador.Next(1, 3) == 1 ? $"{randomizador.Next(-10, 10)}x" : "x";
                }
            }

            MessageBox.Show(formula);
        }

        public double[] obtenerNumerosX()
        {
            if (zoomX == 1) return new double[] { -10, -9, -8, -7, -6, 0, 6, 7, 8, 9, 10 };
            else if (zoomX == 2) return new double[] { -15, -14, -13, -12, -11, 0, 11, 12, 13, 14, 15 };
            else if (zoomX == 3) return new double[] { -20, -19, -18, -17, -16, 0, 16, 17, 18, 19, 20 };
            else if (zoomX == -1) return new double[] { -0.9, -0.8, -0.7, -0.6, -0.5, 0, 0.5, 0.6, 0.7, 0.8, 0.9 };
            else if (zoomX == -2) return new double[] { -0.5, -0.4, -0.3, -0.2, -0.1, 0, 0.1, 0.2, 0.3, 0.4, 0.5 };
            else return new double[] { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };    
        }

        public double[] obtenerNumerosY()
        {
            if (zoomY == 1) return new double[] { -8, -7, -6, -5, 0, 5, 6, 7, 8 };
            else if(zoomY == 2) return new double[] { -12, -11, -10, -9, 0, 9, 10, 11, 12 };
            else if(zoomY == 3) return new double[] { -16, -15, -14, -13, 0, 13, 14, 15, 16 };
            else if(zoomY == -1) return new double[] { -0.9, -0.8, -0.7, -0.6, 0, 0.6, 0.7, 0.8, 0.9 };
            else if (zoomY == -2) return new double[] { -0.5, -0.4, -0.3, -0.2, 0, 0.2, 0.3, 0.4, 0.5 };
            else return new double[] { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AlertaControles.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // RandomizarFuncion();
            RandomizarPuntos();
        }

        private void GraphForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!teclaPresionadaL && !teclaPresionadaR && !teclaPresionadaU
                && !teclaPresionadaD && !teclaPresionadaEnter)
            {
                if (panel1.Location.X != 765)
                {
                    if (e.KeyCode == Keys.Right)
                    {
                        ReproductorSonidos.ReproducirSonido("menu-move.mp3");
                        panel1.Location = new Point(panel1.Location.X + 70, panel1.Location.Y);
                        teclaPresionadaR = true;
                        playerX++;
                        label2.Text = $"({obtenerNumerosX()[playerX]}, {obtenerNumerosY()[playerY]})";
                    }
                }

                if (panel1.Location.X != 65)
                {
                    if (e.KeyCode == Keys.Left)
                    {
                        ReproductorSonidos.ReproducirSonido("menu-move.mp3");
                        panel1.Location = new Point(panel1.Location.X - 70, panel1.Location.Y);
                        teclaPresionadaL = true;
                        playerX--;
                        label2.Text = $"({obtenerNumerosX()[playerX]}, {obtenerNumerosY()[playerY]})";
                    }
                }

                if (panel1.Location.Y != 40)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        ReproductorSonidos.ReproducirSonido("menu-move.mp3");
                        panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 70);
                        teclaPresionadaD = true;
                        playerY++;
                        label2.Text = $"({obtenerNumerosX()[playerX]}, {obtenerNumerosY()[playerY]})";
                    }
                }

                if (panel1.Location.Y != 600)
                {
                    if (e.KeyCode == Keys.Down)
                    {
                        ReproductorSonidos.ReproducirSonido("menu-move.mp3");
                        panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 70);
                        teclaPresionadaU = true;
                        playerY--;
                        label2.Text = $"({obtenerNumerosX()[playerX]}, {obtenerNumerosY()[playerY]})";
                    }
                }

                if (e.KeyCode == Keys.Enter)
                {
                    ReproductorSonidos.ReproducirSonido("put-point.mp3");
                    bool crearLabel = true;

                    foreach (Control control in Controls)
                    {
                        if (control is Label)
                        {
                            if (control.Name.Contains("labelPunto")
                                && panel1.Bounds.IntersectsWith(control.Bounds))
                            {
                                Controls.Remove(control);
                                crearLabel = false;
                                break;
                            }
                        }
                    }

                    if (crearLabel)
                    {
                        Label labelPunto = new Label
                        {
                            Name = $"labelPunto{numeroLabel}",
                            Text = "◉\n",
                            Font = label2.Font,
                            Location = new Point(panel1.Location.X + 1, panel1.Location.Y + 22),
                            BackColor = Color.Transparent,
                            ForeColor = label2.ForeColor,
                            TextAlign = ContentAlignment.MiddleCenter,
                            AutoSize = false,
                            Size = new Size(60, label2.Size.Height + 17)
                        };
                        numeroLabel++;

                        if (Regex.Match(label2.Text, @"\((-?\d+),\s*(-?\d+)\)").Groups[1].Value.Trim() != "0" &&
                            Regex.Match(label2.Text, @"\((-?\d+),\s*(-?\d+)\)").Groups[2].Value.Trim() != "0")
                        {
                            labelPunto.Text += label2.Text;
                        }
                        Controls.Add(labelPunto);
                    }

                    teclaPresionadaEnter = true;
                }
            }

            if (e.Control)
            {
                if (e.KeyCode == Keys.Z)
                {
                    zoomX = zoomX == 3 ? 0 : zoomX + 1;
                    Invalidate();
                } else if(e.KeyCode == Keys.C)
                {
                    zoomY = zoomY == 3 ? 0 : zoomY + 1;
                    Invalidate();
                }
            }
        }

        private void GraphForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) teclaPresionadaR = false;
            else if (e.KeyCode == Keys.Left) teclaPresionadaL = false;
            else if (e.KeyCode == Keys.Up) teclaPresionadaD = false;
            else if (e.KeyCode == Keys.Down) teclaPresionadaU = false;
            else if (e.KeyCode == Keys.Enter) teclaPresionadaEnter = false;
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
