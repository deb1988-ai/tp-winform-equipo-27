namespace TPWinForm_equipo_27
{
    partial class frmAdministradorCategorias
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
            this.components = new System.ComponentModel.Container();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAlta = new System.Windows.Forms.TextBox();
            this.gbxAlta = new System.Windows.Forms.GroupBox();
            this.gbxEditar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.gbxAlta.SuspendLayout();
            this.gbxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(116, 31);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(6, 49);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(116, 31);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(270, 215);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 56);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(12, 12);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(234, 359);
            this.dgvCategorias.TabIndex = 3;
            this.dgvCategorias.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(6, 21);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(116, 22);
            this.txtEditar.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAlta
            // 
            this.txtAlta.Location = new System.Drawing.Point(6, 21);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(116, 22);
            this.txtAlta.TabIndex = 6;
            // 
            // gbxAlta
            // 
            this.gbxAlta.Controls.Add(this.btnAlta);
            this.gbxAlta.Controls.Add(this.txtAlta);
            this.gbxAlta.Location = new System.Drawing.Point(270, 12);
            this.gbxAlta.Name = "gbxAlta";
            this.gbxAlta.Size = new System.Drawing.Size(130, 87);
            this.gbxAlta.TabIndex = 7;
            this.gbxAlta.TabStop = false;
            this.gbxAlta.Text = "Alta";
            // 
            // gbxEditar
            // 
            this.gbxEditar.Controls.Add(this.txtEditar);
            this.gbxEditar.Controls.Add(this.btnEditar);
            this.gbxEditar.Location = new System.Drawing.Point(270, 120);
            this.gbxEditar.Name = "gbxEditar";
            this.gbxEditar.Size = new System.Drawing.Size(130, 89);
            this.gbxEditar.TabIndex = 8;
            this.gbxEditar.TabStop = false;
            this.gbxEditar.Text = "Editar";
            // 
            // frmAdministradorCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 384);
            this.Controls.Add(this.gbxEditar);
            this.Controls.Add(this.gbxAlta);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.btnEliminar);
            this.Name = "frmAdministradorCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador Categorias";
            this.Load += new System.EventHandler(this.frmAdministradorCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.gbxAlta.ResumeLayout(false);
            this.gbxAlta.PerformLayout();
            this.gbxEditar.ResumeLayout(false);
            this.gbxEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAlta;
        private System.Windows.Forms.GroupBox gbxAlta;
        private System.Windows.Forms.GroupBox gbxEditar;
    }
}