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

        #region Métodos
        //Canciones agregadas opr hardCode
        private void CancionesDefault()
        {
            canciones.Add(new Cancion("My demons","Starset","Trasnsmissions"));
            canciones.Add(new Cancion("Time is runnin out", "Muse", "Absolution"));
            canciones.Add(new Cancion("Keep driving", "Harry Styles", "Harrys House"));
            canciones.Add(new Cancion("Presidente Maynez", "Yuawi", "Presidente Maynez"));

        }

        internal void AgregarCancion(Cancion cancion)
        {
            canciones.Add(cancion);
            lstbCanciones.Items.Add(cancion.Titulo);
        }

        #endregion

        #region Manejadores de eventos
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

        private void agregarCanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarMusica formAgregar = new FormAgregarMusica();
            formAgregar.EnviarCancion += AgregarCancion;
            formAgregar.ShowDialog();
        }
        #endregion


    }
}
