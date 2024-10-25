using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetGraphBackend.Configs
{
    public static class ReproductorSonidos
    {

        private static IWavePlayer waveOut;
        private static AudioFileReader audioReader;

        public static void reproducirSonido(string tipoSonido = "")
        {
            waveOut?.Stop();
            waveOut?.Dispose();
            audioReader?.Dispose();

            waveOut = new WaveOut();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tipoSonido);
            audioReader = new AudioFileReader(ruta);
            waveOut.Init(audioReader);
            waveOut.Play();
        }
    }
}
