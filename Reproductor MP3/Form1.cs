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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                //Si no hay un archivo seleecionado
                //Abrimos el explorador de archivos
                if (string.IsNullOrEmpty(archivoSeleccionado))
                {
                    DialogResult resultado =
                        openFileDialog1.ShowDialog();
                    //El usuario cancelo la selección 
                    if (resultado != DialogResult.OK)
                    {
                        return;
                    }
                    //Guardar la ruta del archivo
                    archivoSeleccionado = 
                        openFileDialog1.FileName;
                    //Mostramos el nombre del archivo en el label
                    lbArchivo.Text = "Archivo seleccionado: " +
                        Path.GetFileName(archivoSeleccionado);
                
                }

                //Indicamos al reproductor que reproduzca el archivo seleccionado
                reproductor.URL = archivoSeleccionado;
                //Reproducir sonido
                reproductor.controls.play();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reproducir el archivo: " + ex.Message);
            }
        }
    }
}
