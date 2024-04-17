namespace ReproductorMusica2024_2
{
    partial class FormReproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbCanciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDuracionCancion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbCanciones
            // 
            this.lstbCanciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstbCanciones.FormattingEnabled = true;
            this.lstbCanciones.Location = new System.Drawing.Point(69, 69);
            this.lstbCanciones.Name = "lstbCanciones";
            this.lstbCanciones.Size = new System.Drawing.Size(179, 342);
            this.lstbCanciones.TabIndex = 0;
            this.lstbCanciones.SelectedIndexChanged += new System.EventHandler(this.lstbCanciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(348, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Black;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbTitulo.Location = new System.Drawing.Point(451, 149);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(177, 24);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Movimiento Naranja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(348, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Artista";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.BackColor = System.Drawing.Color.Black;
            this.lbArtista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtista.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbArtista.Location = new System.Drawing.Point(451, 197);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(61, 24);
            this.lbArtista.TabIndex = 2;
            this.lbArtista.Text = "Yawui";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(348, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Álbum";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.BackColor = System.Drawing.Color.Black;
            this.lbAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbum.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbAlbum.Location = new System.Drawing.Point(451, 248);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(177, 24);
            this.lbAlbum.TabIndex = 2;
            this.lbAlbum.Text = "Movimiento Naranja";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar1.Location = new System.Drawing.Point(352, 342);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(458, 14);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(296, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "00:00";
            // 
            // lbDuracionCancion
            // 
            this.lbDuracionCancion.AutoSize = true;
            this.lbDuracionCancion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDuracionCancion.ForeColor = System.Drawing.Color.Lime;
            this.lbDuracionCancion.Location = new System.Drawing.Point(838, 343);
            this.lbDuracionCancion.Name = "lbDuracionCancion";
            this.lbDuracionCancion.Size = new System.Drawing.Size(38, 13);
            this.lbDuracionCancion.TabIndex = 4;
            this.lbDuracionCancion.Text = "1 [min]";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproducciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCanciónToolStripMenuItem,
            this.cargarDefaultToolStripMenuItem,
            this.toolStripMenuItem1,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarDefaultToolStripMenuItem
            // 
            this.cargarDefaultToolStripMenuItem.Name = "cargarDefaultToolStripMenuItem";
            this.cargarDefaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarDefaultToolStripMenuItem.Text = "Cargar Default";
            this.cargarDefaultToolStripMenuItem.Click += new System.EventHandler(this.cargarDefaultToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // reproducciónToolStripMenuItem
            // 
            this.reproducciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pausaToolStripMenuItem});
            this.reproducciónToolStripMenuItem.Name = "reproducciónToolStripMenuItem";
            this.reproducciónToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.reproducciónToolStripMenuItem.Text = "Reproducción";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // pausaToolStripMenuItem
            // 
            this.pausaToolStripMenuItem.Name = "pausaToolStripMenuItem";
            this.pausaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pausaToolStripMenuItem.Text = "Pausa";
            // 
            // agregarCanciónToolStripMenuItem
            // 
            this.agregarCanciónToolStripMenuItem.Name = "agregarCanciónToolStripMenuItem";
            this.agregarCanciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarCanciónToolStripMenuItem.Text = "Agregar Canción";
            this.agregarCanciónToolStripMenuItem.Click += new System.EventHandler(this.agregarCanciónToolStripMenuItem_Click);
            // 
            // FormReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1014, 487);
            this.Controls.Add(this.lbDuracionCancion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbCanciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormReproductor";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbCanciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDuracionCancion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCanciónToolStripMenuItem;
    }
}

