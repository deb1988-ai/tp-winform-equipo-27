namespace TPWinForm_equipo_27
{
    partial class TPWinForm
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
            this.btnAltaArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaArticulo
            // 
            this.btnAltaArticulo.Location = new System.Drawing.Point(644, 46);
            this.btnAltaArticulo.Name = "btnAltaArticulo";
            this.btnAltaArticulo.Size = new System.Drawing.Size(113, 37);
            this.btnAltaArticulo.TabIndex = 0;
            this.btnAltaArticulo.Text = "Agregar artículo";
            this.btnAltaArticulo.UseVisualStyleBackColor = true;
            this.btnAltaArticulo.Click += new System.EventHandler(this.btnAltaArticulo_Click);
            // 
            // TPWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAltaArticulo);
            this.Name = "TPWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TPWinForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAltaArticulo;
    }
}

