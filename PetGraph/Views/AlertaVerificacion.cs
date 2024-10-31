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

        public int eleccion { get; private set; } = 0;

        public AlertaVerificacion()
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
        }

        public AlertaVerificacion(string texto)
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
            label3.Text = $"¿Estás seguro que quieres verificar tu gráfico?" +
                $"\n\nPuntos: {(texto == "" || texto == null ? "Ninguno seleccionado" : texto)}";
        }

        public static void Show()
        {
            AlertaVerificacion alerta = new AlertaVerificacion();
            alerta.ShowDialog();
        }

        public static int Show(string texto)
        {
            AlertaVerificacion alerta = new AlertaVerificacion(texto);
            alerta.ShowDialog();
            return alerta.eleccion;
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

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            eleccion = 0;
            Close();
        }

        private void buttonCompletado_Click(object sender, EventArgs e)
        {
            ReproductorSonidos.ReproducirSonido("menu-select.mp3");
            eleccion = 1;
            Close();
        }
    }
}
