using NAudio.Wave;
using PetGraphBackend.Objetos;
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

        private static IWavePlayer waveOutOnce, waveOutLoop;
        private static AudioFileReader audioReaderOnce, audioReaderLoop;

        public static void ReproducirSonido(string tipoSonido = "")
        {
            waveOutOnce?.Stop();
            waveOutOnce?.Dispose();
            audioReaderOnce?.Dispose();

            waveOutOnce = new WaveOutEvent();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tipoSonido);
            audioReaderOnce = new AudioFileReader(ruta);
            waveOutOnce.Init(audioReaderOnce);
            waveOutOnce.Play();
        }

        public static void ReproducirMusica(string tipoMusica = "")
        {
            waveOutLoop?.Stop();
            waveOutLoop?.Dispose();
            audioReaderLoop?.Dispose();

            waveOutLoop = new WaveOutEvent();
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, tipoMusica);
            audioReaderLoop = new AudioFileReader(ruta);
            waveOutLoop.Init(new LoopStream(audioReaderLoop));
            waveOutLoop.Play();
        }

        public static void EstablecerVolumen(float volumen = 1f)
        {
            waveOutLoop.Volume = volumen;
        }
    }
}
