﻿namespace TPWinForm_equipo_27
{
    partial class AltaArticulo
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
            this.SuspendLayout();
            // 
            // Codigolbl
            // 
            this.Codigolbl.AutoSize = true;
            this.Codigolbl.Location = new System.Drawing.Point(12, 32);
            this.Codigolbl.Name = "Codigolbl";
            this.Codigolbl.Size = new System.Drawing.Size(40, 13);
            this.Codigolbl.TabIndex = 0;
            this.Codigolbl.Text = "Codigo";
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Location = new System.Drawing.Point(12, 68);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(44, 13);
            this.Nombrelbl.TabIndex = 1;
            this.Nombrelbl.Text = "Nombre";
            // 
            // Descripcionlbl
            // 
            this.Descripcionlbl.AutoSize = true;
            this.Descripcionlbl.Location = new System.Drawing.Point(12, 115);
            this.Descripcionlbl.Name = "Descripcionlbl";
            this.Descripcionlbl.Size = new System.Drawing.Size(63, 13);
            this.Descripcionlbl.TabIndex = 2;
            this.Descripcionlbl.Text = "Descripcion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(97, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 108);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(97, 325);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 325);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 534);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.Descripcionlbl);
            this.Controls.Add(this.Nombrelbl);
            this.Controls.Add(this.Codigolbl);
            this.Name = "AltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaArticulo";
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
    }
}