using System;
using System.Windows.Forms;
using System.Collections;

namespace ReproductorMusica2024_2
{
    public partial class FormReproductor : Form
    {

        //Ejemplo
        private ArrayList canciones;
        public FormReproductor()
        {
            InitializeComponent();
            canciones = new ArrayList();
        }

        //Canciones agregadas opr hardCode
        private void CancionesDefault()
        {
            canciones.Add(new Cancion("My demons","Starset","Trasnsmissions"));
            canciones.Add(new Cancion("Time is runnin out", "Muse", "Absolution"));
            canciones.Add(new Cancion("Keep driving", "Harry Styles", "Harrys House"));
            canciones.Add(new Cancion("Presidente Maynez", "Yuawi", "Presidente Maynez"));

        }

        private void cargarDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancionesDefault();
            foreach (var cancion in canciones)
            {
                Cancion miCancion = (Cancion)cancion;
                lstbCanciones.Items.Add(miCancion.Titulo);
            }
        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cancion miCancion = (Cancion)canciones[lstbCanciones.SelectedIndex];
            lbTitulo.Text = miCancion.Titulo;
            lbArtista.Text = miCancion.Artista;
            lbAlbum.Text = miCancion.Album;
        }
    }
}
