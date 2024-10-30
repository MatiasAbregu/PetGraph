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
    public partial class AlertaVerificacion : Form
    {
        public AlertaVerificacion()
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
        }

        public static void Show()
        {
            AlertaVerificacion alerta = new AlertaVerificacion();
            alerta.ShowDialog();
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
