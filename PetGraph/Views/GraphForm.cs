using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGraph.Views
{
    public partial class GraphForm : Form
    {
        public GraphForm()
        {
            InitializeComponent();
        }

        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Width: 900; Height: 750 (FORMULARIO)

            // Lapiz color y trazo
            Pen pen = new Pen(Color.Black, 3);

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
            g.FillPolygon(Brushes.Black, puntaSuperior);

            Point[] puntaInferior = { new Point(Ox1, Oy2 + 2), 
                new Point(Ox1 - 10, Oy2 - 15), new Point(Ox1 + 10, Oy2 - 15) };
            g.FillPolygon(Brushes.Black, puntaInferior);

            // Eje de Abscisas
            int Ax1 = 40;
            int Ax2 = 850;
            int Ay1 = 355;
            Point startPoint2 = new Point(Ax1, Ay1);
            Point endPoint2 = new Point(Ax2, Ay1);
            g.DrawLine(pen, startPoint2, endPoint2);
            g.DrawLine(pen, startPoint2, endPoint2);

            // Puntas FLECHAS
            Point[] puntaDerecha = { new Point(Ax2, Ay1),
                new Point(Ax2 - 15, Ay1 - 10), new Point(Ax2 - 15, Ay1 + 10) };
            g.FillPolygon(Brushes.Black, puntaDerecha);

            Point[] puntaIzquierda = { new Point(Ax1, Ay1),
                new Point(Ax1 + 15, Ay1 - 10), new Point(Ax1 + 15, Ay1 + 10) };
            g.FillPolygon(Brushes.Black, puntaIzquierda);

            // Liberar los recursos
            pen.Dispose();
        }
    }
}
