using WMPLib;

namespace Reproductor_MP3
{
    public partial class Programa : Form
    {
        //Objeto  que se encargará de reproducir el audio

        private WindowsMediaPlayer reproductor;

        //Guarda la ruta del archivo seleccionado

        private string archivoSeleccionado;

        public Programa()
        {
            InitializeComponent();
            //Creamos el reproductor
            reproductor = new WindowsMediaPlayer();
            //Evita que reproduzca un audio
            reproductor.settings.autoStart = false;
            //Configuramos el OpenFileDialog
            openFileDialog1.Filter =
                "Archivos de audio (*.mp3)|*.mp3";
            openFileDialog1.Title = "Selecciona un archivo MP3";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            reproductor.controls.stop();
            btnPlayPause.Image = new Bitmap(Properties.Resources.IconPlay, new Size(30, 30));
            estaReproduciendo = false;
        }

        /// ===========================
        /// Liberar el reproductor al cerrar el formulario
        /// ===========================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            reproductor.controls.stop();
            reproductor.close();
            base.OnFormClosing(e);
        }
        
        private bool estaReproduciendo = false;
        //Esto es por si acaso lo vuelvo a usar
        private Image iconoPlay = new Bitmap(Properties.Resources.IconPlay, new Size(42, 42));
        private Image iconoPause = new Bitmap(Properties.Resources.IconPause, new Size(42, 42));

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                reproductor.controls.stop();

                archivoSeleccionado = openFileDialog1.FileName;
                lbArchivo.Text = "Archivo seleccionado: " + Path.GetFileName(archivoSeleccionado);

                reproductor.URL = archivoSeleccionado;
                reproductor.controls.play();

                btnPlayPause.Image = new Bitmap(Properties.Resources.IconPause, new Size(42, 42));
                estaReproduciendo = true;
            }

        }


        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(archivoSeleccionado))
                {
                    DialogResult resultado = openFileDialog1.ShowDialog();
                    if (resultado != DialogResult.OK)
                    {
                        return;
                    }
                    archivoSeleccionado = openFileDialog1.FileName;
                    lbArchivo.Text = "Archivo seleccionado: " + Path.GetFileName(archivoSeleccionado);
                    reproductor.URL = archivoSeleccionado;
                }

                if (!estaReproduciendo)
                {
                    reproductor.controls.play();
                    btnPlayPause.Image = new Bitmap(Properties.Resources.IconPause, new Size(42, 42));
                    estaReproduciendo = true;
                }
                else
                {
                    reproductor.controls.pause();
                    btnPlayPause.Image = new Bitmap(Properties.Resources.IconPlay, new Size(42, 42));
                    estaReproduciendo = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el archivo: " + ex.Message);
            }
        }
    }
}
