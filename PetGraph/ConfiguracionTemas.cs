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
        private static bool tema = true, logo = true;

        public static void EstablecerTema(Form formulario, bool cambioTema = false)
        {
            formulario.BackColor = tema ? Color.White : Color.FromArgb(30, 30, 30);

            foreach (Control controlTemp in formulario.Controls)
            {
                if(controlTemp is Label)
                {
                    controlTemp.ForeColor = tema ? Color.FromArgb(30, 30, 30) : Color.White;
                }

                if (controlTemp is Button)
                {
                    controlTemp.BackColor = tema ? Color.FromArgb(30, 30, 30) : Color.White;
                    controlTemp.ForeColor = tema ? Color.White : Color.FromArgb(30, 30, 30);
                }
            }

            if(cambioTema) tema = !tema;
        }

        public static void EstablecerLogoTema(PictureBox pictureBox)
        {
            pictureBox.Image = logo ? Properties.Resources.moongif : Properties.Resources.sungif;
            logo = !logo;
        }
    }
}