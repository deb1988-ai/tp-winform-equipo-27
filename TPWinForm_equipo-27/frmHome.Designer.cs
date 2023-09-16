namespace TPWinForm_equipo_27
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            this.btnAltaArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.imlArticulos = new System.Windows.Forms.ImageList(this.components);
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnMarcasAdministrador = new System.Windows.Forms.Button();
            this.btnCategoriaAdministrador = new System.Windows.Forms.Button();
            this.btnImagenes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaArticulo
            // 
            this.btnAltaArticulo.Location = new System.Drawing.Point(660, 29);
            this.btnAltaArticulo.Name = "btnAltaArticulo";
            this.btnAltaArticulo.Size = new System.Drawing.Size(91, 40);
            this.btnAltaArticulo.TabIndex = 0;
            this.btnAltaArticulo.Text = "Agregar artículo";
            this.btnAltaArticulo.UseVisualStyleBackColor = true;
            this.btnAltaArticulo.Click += new System.EventHandler(this.btnAltaArticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(32, 29);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(622, 299);
            this.dgvArticulos.TabIndex = 3;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // imlArticulos
            // 
            this.imlArticulos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlArticulos.ImageSize = new System.Drawing.Size(16, 16);
            this.imlArticulos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(660, 167);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(183, 115);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 4;
            this.pbxArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::TPWinForm_equipo_27.Properties.Resources.pen_to_square_solid3;
            this.btnModificar.Location = new System.Drawing.Point(757, 29);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(40, 40);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TPWinForm_equipo_27.Properties.Resources.trash_solid3;
            this.btnEliminar.Location = new System.Drawing.Point(803, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnMarcasAdministrador
            // 
            this.btnMarcasAdministrador.Location = new System.Drawing.Point(660, 75);
            this.btnMarcasAdministrador.Name = "btnMarcasAdministrador";
            this.btnMarcasAdministrador.Size = new System.Drawing.Size(183, 40);
            this.btnMarcasAdministrador.TabIndex = 5;
            this.btnMarcasAdministrador.Text = "Administrador Marcas";
            this.btnMarcasAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnCategoriaAdministrador
            // 
            this.btnCategoriaAdministrador.Location = new System.Drawing.Point(660, 121);
            this.btnCategoriaAdministrador.Name = "btnCategoriaAdministrador";
            this.btnCategoriaAdministrador.Size = new System.Drawing.Size(183, 40);
            this.btnCategoriaAdministrador.TabIndex = 6;
            this.btnCategoriaAdministrador.Text = "Administrador Categorias";
            this.btnCategoriaAdministrador.UseVisualStyleBackColor = true;
            // 
            // btnImagenes
            // 
            this.btnImagenes.Location = new System.Drawing.Point(660, 288);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(183, 40);
            this.btnImagenes.TabIndex = 7;
            this.btnImagenes.Text = "Ver Imagenes";
            this.btnImagenes.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 360);
            this.Controls.Add(this.btnImagenes);
            this.Controls.Add(this.btnCategoriaAdministrador);
            this.Controls.Add(this.btnMarcasAdministrador);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAltaArticulo);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Articulos";
            this.Load += new System.EventHandler(this.TPWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaArticulo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.ImageList imlArticulos;
        private System.Windows.Forms.Button btnMarcasAdministrador;
        private System.Windows.Forms.Button btnCategoriaAdministrador;
        private System.Windows.Forms.Button btnImagenes;
    }
}

