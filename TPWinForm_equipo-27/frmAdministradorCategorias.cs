using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPWinForm_equipo_27
{
    public partial class frmAdministradorCategorias : Form
    {
        private List<Categorias> listaCategorias;
        public frmAdministradorCategorias()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categorias categoria = new Categorias();
            try
            {
                if (txtAlta.Text == "")
                {
                    MessageBox.Show("Ingresar marca");
                    return;
                }
                categoria.Descripcion = txtAlta.Text;
                categoriaNegocio.agregar(categoria);
                txtAlta.Text = "";
                cargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            Categorias categoriaSeleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    categoriaSeleccionada = (Categorias)dgvCategorias.CurrentRow.DataBoundItem;
                    categoriaNegocio.eliminar(categoriaSeleccionada.Id);

                    cargarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmAdministradorCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }

        private void cargarCategorias()
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                listaCategorias = categoriaNegocio.listar();

                dgvCategorias.DataSource = listaCategorias;
                dgvCategorias.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            Categorias categoria = (Categorias)dgvCategorias.CurrentRow.DataBoundItem;
            txtEditar.Text = categoria.Descripcion;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            Categorias marca = (Categorias)dgvCategorias.CurrentRow.DataBoundItem;
            marca.Descripcion = txtEditar.Text;

            categoriaNegocio.editar(marca);
            txtEditar.Text = "";
            cargarCategorias();
        }
    }
}
