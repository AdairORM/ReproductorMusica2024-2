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
            EnviarCancion(new Cancion(txtbTitulo.Text,txtbArtista.Text,txtbAlbum.Text));
        }
    }
}
