﻿using System;
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
    public partial class AlertaControles : Form
    {
        public AlertaControles()
        {
            InitializeComponent();
            ConfiguracionTemas.EstablecerTema(this);
        }

        public static void Show()
        {
            AlertaControles alerta = new AlertaControles();

            alerta.ShowDialog();
        }
    }
}