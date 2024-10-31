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


        public static void EstablecerTema(Form formulario, bool cambioTema = false,
            PictureBox animal = null)
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
                    if (!controlTemp.Name.Equals("buttonCerrar") &&
                            !controlTemp.Name.Equals("buttonCompletado"))
                    {
                        controlTemp.BackColor = tema ? Color.FromArgb(30, 30, 30) : Color.White;
                        controlTemp.ForeColor = tema ? Color.White : Color.FromArgb(30, 30, 30);
                    } 
                }

                if (controlTemp is Panel)
                {
                    foreach (Control controlTemp2 in controlTemp.Controls)
                    {
                        if (!controlTemp2.Name.Equals("labelCerrar") && 
                            !controlTemp2.Name.Equals("buttonCompletado"))
                        {
                            controlTemp2.ForeColor = tema ? Color.FromArgb(30, 30, 30) : Color.White;
                        }
                    }
                }

                if (animal != null)
                {
                    if (tema)
                        animal.Image = PetGraphBackend.Properties.Resources.dogStart;
                    else
                        animal.Image = PetGraphBackend.Properties.Resources.catlogo;

                }
            }
        }
        public static void EstablecerLogoTema(PictureBox pictureBox)
        {
            pictureBox.Image = logo ? PetGraphBackend.Properties.Resources.moongif : PetGraphBackend.Properties.Resources.sungif;
            logo = !logo;
        }

        public static Color ObtenerColorParaGrafica()
        {
            if (tema) return Color.FromArgb(30, 30, 30);
            else return Color.White;
        }
    }
}
