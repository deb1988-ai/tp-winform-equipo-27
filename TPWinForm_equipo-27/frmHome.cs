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

        private void TPWinForm_Load(object sender, EventArgs e)
        {
            cargarArticulos();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Marca");     
        }

        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            frmArticuloAlta alta = new frmArticuloAlta();
            alta.ShowDialog();
            cargarArticulos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo Articuloseleccionado;
            if(dgvArticulos.CurrentCell is null)
            {
                MessageBox.Show("Debe Seleccionar un Artículo");
            }
            else
            {
                Articuloseleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                frmArticuloAlta modificar = new frmArticuloAlta(Articuloseleccionado);
                modificar.ShowDialog();
                cargarArticulos();
            } 
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo articuloSeleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(articuloSeleccionado.Id);

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
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articuloSeleccionado.ListaImagenes);
            }
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
        

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmImagenes imagenes = new frmImagenes(articulo.ListaImagenes);
            imagenes.ShowDialog();
            cargarArticulos();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Nombre")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Ingresar un nombre");
                    return true;
                }
            }
            if (cboCampo.SelectedItem.ToString() == "Marca")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Ingresar marca");
                    return true;
               
                }
            }
            if (cboCampo.SelectedItem.ToString() == "Descripción")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Ingresar descripcion");
                    return true;
                }
            }
            if (cboCampo.SelectedItem.ToString() == "Código")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Ingresar descripcion");
                    return true;
                }
            }

            return false;
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
        }
    }
}
