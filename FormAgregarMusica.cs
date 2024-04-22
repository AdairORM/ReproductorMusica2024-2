using System;
using System.Windows.Forms;

namespace ReproductorMusica2024_2
{
    public partial class FormAgregarMusica : Form
    {//los manejadores de texto "internal" debde de ser el mismo entre el eveno y el delegado
        internal delegate void DelegateCancion(Cancion cancion);
        internal event DelegateCancion EnviarCancion;

        public FormAgregarMusica()
        {
            InitializeComponent();
        }

        private void btnaAgregar_Click(object sender, EventArgs e)
        {
            int duracion;
            bool esNumero = int.TryParse(txtbDuracion.Text, out duracion);
            EnviarCancion(new Cancion(txtbTitulo.Text,txtbArtista.Text,txtbAlbum.Text, duracion));
            txtbAlbum.Clear();
            txtbTitulo.Clear();
            txtbArtista.Clear();
            txtbAlbum.Clear();

        }
    }
}
