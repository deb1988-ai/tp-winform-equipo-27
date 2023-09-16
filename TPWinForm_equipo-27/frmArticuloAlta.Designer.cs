namespace TPWinForm_equipo_27
{
    partial class frmArticuloAlta
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
            this.Codigolbl = new System.Windows.Forms.Label();
            this.Nombrelbl = new System.Windows.Forms.Label();
            this.Descripcionlbl = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtMarca = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.cboImagenes = new System.Windows.Forms.ComboBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.btnQuitarImagen = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigolbl
            // 
            this.Codigolbl.AutoSize = true;
            this.Codigolbl.Location = new System.Drawing.Point(52, 19);
            this.Codigolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Codigolbl.Name = "Codigolbl";
            this.Codigolbl.Size = new System.Drawing.Size(54, 16);
            this.Codigolbl.TabIndex = 0;
            this.Codigolbl.Text = "Código:";
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Location = new System.Drawing.Point(47, 48);
            this.Nombrelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(59, 16);
            this.Nombrelbl.TabIndex = 1;
            this.Nombrelbl.Text = "Nombre:";
            // 
            // Descripcionlbl
            // 
            this.Descripcionlbl.AutoSize = true;
            this.Descripcionlbl.Location = new System.Drawing.Point(26, 78);
            this.Descripcionlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcionlbl.Name = "Descripcionlbl";
            this.Descripcionlbl.Size = new System.Drawing.Size(82, 16);
            this.Descripcionlbl.TabIndex = 2;
            this.Descripcionlbl.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(114, 13);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(160, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(114, 72);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(160, 22);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(114, 278);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 28);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 278);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(114, 101);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(160, 24);
            this.cboMarca.TabIndex = 8;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(114, 133);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(160, 24);
            this.cboCategoria.TabIndex = 9;
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Location = new System.Drawing.Point(58, 109);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(48, 16);
            this.txtMarca.TabIndex = 10;
            this.txtMarca.Text = "Marca:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.Location = new System.Drawing.Point(37, 141);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(69, 16);
            this.txtCategoria.TabIndex = 11;
            this.txtCategoria.Text = "Categoria:";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(282, 13);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(209, 174);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 12;
            this.pbxArticulo.TabStop = false;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(39, 234);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(137, 16);
            this.lblImagen.TabIndex = 13;
            this.lblImagen.Text = "Agregar URL Imagen:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(184, 228);
            this.txtUrlImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(160, 22);
            this.txtUrlImagen.TabIndex = 14;
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Location = new System.Drawing.Point(37, 202);
            this.lblImagenes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(70, 16);
            this.lblImagenes.TabIndex = 16;
            this.lblImagenes.Text = "Imagenes:";
            // 
            // cboImagenes
            // 
            this.cboImagenes.FormattingEnabled = true;
            this.cboImagenes.Location = new System.Drawing.Point(114, 194);
            this.cboImagenes.Margin = new System.Windows.Forms.Padding(4);
            this.cboImagenes.Name = "cboImagenes";
            this.cboImagenes.Size = new System.Drawing.Size(160, 24);
            this.cboImagenes.TabIndex = 15;
            this.cboImagenes.SelectedIndexChanged += new System.EventHandler(this.cboImagenes_SelectedIndexChanged);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(351, 226);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(140, 26);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // btnQuitarImagen
            // 
            this.btnQuitarImagen.Location = new System.Drawing.Point(281, 194);
            this.btnQuitarImagen.Name = "btnQuitarImagen";
            this.btnQuitarImagen.Size = new System.Drawing.Size(210, 26);
            this.btnQuitarImagen.TabIndex = 18;
            this.btnQuitarImagen.Text = "Quitar Imagen";
            this.btnQuitarImagen.UseVisualStyleBackColor = true;
            this.btnQuitarImagen.Click += new System.EventHandler(this.btnQuitarImagen_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(114, 165);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(160, 22);
            this.txtPrecio.TabIndex = 20;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(57, 171);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Precio:";
            // 
            // frmArticuloAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 329);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.btnQuitarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.lblImagenes);
            this.Controls.Add(this.cboImagenes);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Descripcionlbl);
            this.Controls.Add(this.Nombrelbl);
            this.Controls.Add(this.Codigolbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmArticuloAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigolbl;
        private System.Windows.Forms.Label Nombrelbl;
        private System.Windows.Forms.Label Descripcionlbl;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.ComboBox cboImagenes;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Button btnQuitarImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
    }
}