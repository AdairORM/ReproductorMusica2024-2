namespace ReproductorMusica2024_2
{
    partial class FormAgregarMusica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbTitulo = new System.Windows.Forms.TextBox();
            this.txtbArtista = new System.Windows.Forms.TextBox();
            this.txtbAlbum = new System.Windows.Forms.TextBox();
            this.btnaAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbDuracion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Artista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Álbum";
            // 
            // txtbTitulo
            // 
            this.txtbTitulo.Location = new System.Drawing.Point(227, 58);
            this.txtbTitulo.Name = "txtbTitulo";
            this.txtbTitulo.Size = new System.Drawing.Size(191, 20);
            this.txtbTitulo.TabIndex = 1;
            // 
            // txtbArtista
            // 
            this.txtbArtista.Location = new System.Drawing.Point(227, 109);
            this.txtbArtista.Name = "txtbArtista";
            this.txtbArtista.Size = new System.Drawing.Size(191, 20);
            this.txtbArtista.TabIndex = 1;
            // 
            // txtbAlbum
            // 
            this.txtbAlbum.Location = new System.Drawing.Point(227, 166);
            this.txtbAlbum.Name = "txtbAlbum";
            this.txtbAlbum.Size = new System.Drawing.Size(191, 20);
            this.txtbAlbum.TabIndex = 1;
            // 
            // btnaAgregar
            // 
            this.btnaAgregar.Location = new System.Drawing.Point(181, 272);
            this.btnaAgregar.Name = "btnaAgregar";
            this.btnaAgregar.Size = new System.Drawing.Size(146, 41);
            this.btnaAgregar.TabIndex = 2;
            this.btnaAgregar.Text = "Agregar";
            this.btnaAgregar.UseVisualStyleBackColor = true;
            this.btnaAgregar.Click += new System.EventHandler(this.btnaAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Duración";
            // 
            // txtbDuracion
            // 
            this.txtbDuracion.Location = new System.Drawing.Point(227, 215);
            this.txtbDuracion.Name = "txtbDuracion";
            this.txtbDuracion.Size = new System.Drawing.Size(191, 20);
            this.txtbDuracion.TabIndex = 1;
            // 
            // FormAgregarMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 385);
            this.Controls.Add(this.btnaAgregar);
            this.Controls.Add(this.txtbDuracion);
            this.Controls.Add(this.txtbAlbum);
            this.Controls.Add(this.txtbArtista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarMusica";
            this.Text = "FormAgregarMusica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbTitulo;
        private System.Windows.Forms.TextBox txtbArtista;
        private System.Windows.Forms.TextBox txtbAlbum;
        private System.Windows.Forms.Button btnaAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbDuracion;
    }
}