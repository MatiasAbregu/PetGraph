using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGraphBackend.Objetos
{
    public class PointGraph
    {
        public double valorX { set; get; }
        public double valorY { set; get; }
        public Label contenido { set; get; }

        public PointGraph() { }

        public PointGraph(double valorX, double valorY, Label contenido)
        {
            this.valorX = valorX;
            this.valorY = valorY;
            this.contenido = contenido;
        }
    }
}
