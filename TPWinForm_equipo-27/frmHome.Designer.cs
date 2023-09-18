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
            this.btnMarcasAdministrador = new System.Windows.Forms.Button();
            this.btnCategoriaAdministrador = new System.Windows.Forms.Button();
            this.btnImagenes = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.gbxFiltros = new System.Windows.Forms.GroupBox();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAltaArticulo
            // 
            this.btnAltaArticulo.Location = new System.Drawing.Point(589, 23);
            this.btnAltaArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.btnAltaArticulo.Name = "btnAltaArticulo";
            this.btnAltaArticulo.Size = new System.Drawing.Size(254, 89);
            this.btnAltaArticulo.TabIndex = 0;
            this.btnAltaArticulo.Text = "Agregar artículo";
            this.btnAltaArticulo.UseVisualStyleBackColor = true;
            this.btnAltaArticulo.Click += new System.EventHandler(this.btnAltaArticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(14, 122);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(5);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(829, 387);
            this.dgvArticulos.TabIndex = 3;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // imlArticulos
            // 
            this.imlArticulos.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlArticulos.ImageSize = new System.Drawing.Size(16, 16);
            this.imlArticulos.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnMarcasAdministrador
            // 
            this.btnMarcasAdministrador.Location = new System.Drawing.Point(866, 122);
            this.btnMarcasAdministrador.Margin = new System.Windows.Forms.Padding(5);
            this.btnMarcasAdministrador.Name = "btnMarcasAdministrador";
            this.btnMarcasAdministrador.Size = new System.Drawing.Size(244, 49);
            this.btnMarcasAdministrador.TabIndex = 5;
            this.btnMarcasAdministrador.Text = "Administrador Marcas";
            this.btnMarcasAdministrador.UseVisualStyleBackColor = true;
            this.btnMarcasAdministrador.Click += new System.EventHandler(this.btnMarcasAdministrador_Click);
            // 
            // btnCategoriaAdministrador
            // 
            this.btnCategoriaAdministrador.Location = new System.Drawing.Point(866, 192);
            this.btnCategoriaAdministrador.Margin = new System.Windows.Forms.Padding(5);
            this.btnCategoriaAdministrador.Name = "btnCategoriaAdministrador";
            this.btnCategoriaAdministrador.Size = new System.Drawing.Size(244, 49);
            this.btnCategoriaAdministrador.TabIndex = 6;
            this.btnCategoriaAdministrador.Text = "Administrador Categorias";
            this.btnCategoriaAdministrador.UseVisualStyleBackColor = true;
            this.btnCategoriaAdministrador.Click += new System.EventHandler(this.btnCategoriaAdministrador_Click);
            // 
            // btnImagenes
            // 
            this.btnImagenes.Location = new System.Drawing.Point(866, 460);
            this.btnImagenes.Margin = new System.Windows.Forms.Padding(5);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(244, 49);
            this.btnImagenes.TabIndex = 7;
            this.btnImagenes.Text = "Ver Imagenes";
            this.btnImagenes.UseVisualStyleBackColor = true;
            this.btnImagenes.Click += new System.EventHandler(this.btnImagenes_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(17, 25);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(15, 61);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 9;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(299, 25);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(36, 16);
            this.lblFiltro.TabIndex = 10;
            this.lblFiltro.Text = "Filtro";
            // 
            // cboCampo
            // 
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(79, 22);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(188, 24);
            this.cboCampo.TabIndex = 11;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(79, 55);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(188, 24);
            this.cboCriterio.TabIndex = 12;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(345, 22);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(188, 22);
            this.txtFiltro.TabIndex = 13;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(302, 55);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(114, 28);
            this.btnFiltro.TabIndex = 14;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // gbxFiltros
            // 
            this.gbxFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.gbxFiltros.Controls.Add(this.cboCampo);
            this.gbxFiltros.Controls.Add(this.btnFiltro);
            this.gbxFiltros.Controls.Add(this.lblCampo);
            this.gbxFiltros.Controls.Add(this.txtFiltro);
            this.gbxFiltros.Controls.Add(this.lblFiltro);
            this.gbxFiltros.Controls.Add(this.cboCriterio);
            this.gbxFiltros.Controls.Add(this.lblCriterio);
            this.gbxFiltros.Location = new System.Drawing.Point(14, 14);
            this.gbxFiltros.Name = "gbxFiltros";
            this.gbxFiltros.Size = new System.Drawing.Size(552, 100);
            this.gbxFiltros.TabIndex = 15;
            this.gbxFiltros.TabStop = false;
            this.gbxFiltros.Text = "Filtros";
            // 
            // btnDetalles
            // 
            this.btnDetalles.Image = global::TPWinForm_equipo_27.Properties.Resources.circle_info_solid3;
            this.btnDetalles.Location = new System.Drawing.Point(866, 25);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(5);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(70, 87);
            this.btnDetalles.TabIndex = 16;
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(866, 263);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(5);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(244, 177);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 4;
            this.pbxArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::TPWinForm_equipo_27.Properties.Resources.pen_to_square_solid3;
            this.btnModificar.Location = new System.Drawing.Point(954, 24);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(70, 87);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::TPWinForm_equipo_27.Properties.Resources.trash_solid3;
            this.btnEliminar.Location = new System.Drawing.Point(1040, 25);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 87);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(424, 55);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(109, 28);
            this.btnLimpiarFiltros.TabIndex = 15;
            this.btnLimpiarFiltros.Text = "Limpiar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 523);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.gbxFiltros);
            this.Controls.Add(this.btnImagenes);
            this.Controls.Add(this.btnCategoriaAdministrador);
            this.Controls.Add(this.btnMarcasAdministrador);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAltaArticulo);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Articulos";
            this.Load += new System.EventHandler(this.TPWinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbxFiltros.ResumeLayout(false);
            this.gbxFiltros.PerformLayout();
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
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.GroupBox gbxFiltros;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}

