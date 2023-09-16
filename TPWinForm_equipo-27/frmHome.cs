using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TPWinForm_equipo_27
{
    public partial class frmHome : Form
    {
        private List<Articulo> listaArticulos;

        public frmHome()
        {
            InitializeComponent();
        }

        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            frmArticuloAlta alta = new frmArticuloAlta();
            alta.ShowDialog();
            cargarArticulos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if(dgvArticulos.CurrentCell is null)
            {
                MessageBox.Show("Debe Seleccionar un Artículo");
            }
            else
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmArticuloAlta modificar = new frmArticuloAlta();
                modificar.ShowDialog();
                cargarArticulos();
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Codigo);

                    cargarArticulos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarArticulos()
        {
            ArticuloNegocio Articulonegocio = new ArticuloNegocio();
            try
            {
                listaArticulos = Articulonegocio.listarArticulos();

                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articuloSeleccionado.ListaImagenes);
        }
        private void cargarImagen(List<Imagenes> listaImagenes)
        {
            try
            {
                pbxArticulo.Load(listaImagenes[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void TPWinForm_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

    }
}
