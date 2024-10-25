using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGraph
{
    public static class ConfiguracionTemas
    {
        private static bool tema = true; 
        private static bool logo = true;


        public static void EstablecerTema(Form formulario, bool cambioTema = false)
        {
            if (cambioTema) tema = !tema;
            formulario.BackColor = tema ? Color.White : Color.FromArgb(30, 30, 30);
            foreach (Control controlTemp in formulario.Controls)
            {
                if (controlTemp is Label)
                {
                    controlTemp.ForeColor = tema ? Color.FromArgb(30, 30, 30) : Color.White;
                }

                if (controlTemp is Button)
                {
                    controlTemp.BackColor = tema ? Color.FromArgb(30, 30, 30) : Color.White;
                    controlTemp.ForeColor = tema ? Color.White : Color.FromArgb(30, 30, 30);
                }
            }
        }
        public static void EstablecerLogoTema(PictureBox pictureBox)
        {
            pictureBox.Image = logo ? PetGraphBackend.Properties.Resources.moongif : PetGraphBackend.Properties.Resources.sungif;
            logo = !logo;
        }
    }
}
