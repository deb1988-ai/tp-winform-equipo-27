namespace TPWinForm_equipo_27
{
    partial class frmAdministradorMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtAlta = new System.Windows.Forms.TextBox();
            this.gbxAlta = new System.Windows.Forms.GroupBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.gbxEditar = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.gbxAlta.SuspendLayout();
            this.gbxEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(12, 12);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.Size = new System.Drawing.Size(241, 356);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(6, 49);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(122, 34);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(6, 49);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(122, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(288, 232);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 55);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtAlta
            // 
            this.txtAlta.Location = new System.Drawing.Point(6, 21);
            this.txtAlta.Name = "txtAlta";
            this.txtAlta.Size = new System.Drawing.Size(122, 22);
            this.txtAlta.TabIndex = 4;
            // 
            // gbxAlta
            // 
            this.gbxAlta.Controls.Add(this.btnAlta);
            this.gbxAlta.Controls.Add(this.txtAlta);
            this.gbxAlta.Location = new System.Drawing.Point(288, 12);
            this.gbxAlta.Name = "gbxAlta";
            this.gbxAlta.Size = new System.Drawing.Size(135, 89);
            this.gbxAlta.TabIndex = 5;
            this.gbxAlta.TabStop = false;
            this.gbxAlta.Text = "Alta";
            // 
            // txtEditar
            // 
            this.txtEditar.Location = new System.Drawing.Point(6, 21);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(122, 22);
            this.txtEditar.TabIndex = 6;
            // 
            // gbxEditar
            // 
            this.gbxEditar.Controls.Add(this.txtEditar);
            this.gbxEditar.Controls.Add(this.btnEditar);
            this.gbxEditar.Location = new System.Drawing.Point(288, 116);
            this.gbxEditar.Name = "gbxEditar";
            this.gbxEditar.Size = new System.Drawing.Size(135, 90);
            this.gbxEditar.TabIndex = 7;
            this.gbxEditar.TabStop = false;
            this.gbxEditar.Text = "Editar";
            // 
            // frmAdministradorMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 392);
            this.Controls.Add(this.gbxEditar);
            this.Controls.Add(this.gbxAlta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "frmAdministradorMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador Marcas";
            this.Load += new System.EventHandler(this.frmAdministradorMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.gbxAlta.ResumeLayout(false);
            this.gbxAlta.PerformLayout();
            this.gbxEditar.ResumeLayout(false);
            this.gbxEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtAlta;
        private System.Windows.Forms.GroupBox gbxAlta;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.GroupBox gbxEditar;
    }
}