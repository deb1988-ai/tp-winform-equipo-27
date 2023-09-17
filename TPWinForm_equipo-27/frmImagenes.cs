using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;

namespace TPWinForm_equipo_27
{
    public partial class frmImagenes : Form
    {
        List<Imagenes> listaImagenes = null;
        public frmImagenes(List<Imagenes> lista)
        {
            InitializeComponent();
            listaImagenes = lista;
        }

        private void frmImagenes_Load(object sender, EventArgs e)
        {
            cboImagenes.Items.Clear();
            cboImagenes.DataSource = listaImagenes;
            cboImagenes.ValueMember = "Id";
            cboImagenes.DisplayMember = "ImagenUrl";

            cboImagenes.SelectedValue = listaImagenes[0].Id;
            cargarImagen(listaImagenes[0].ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void cboImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imagenes imagenSeleccionada = (Imagenes)cboImagenes.SelectedItem;
            cargarImagen(imagenSeleccionada.ImagenUrl);
        }
    }
}
