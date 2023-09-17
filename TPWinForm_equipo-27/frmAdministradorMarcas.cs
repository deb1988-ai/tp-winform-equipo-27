using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPWinForm_equipo_27
{
    public partial class frmAdministradorMarcas : Form
    {
        private List<Marcas> listaMarcas;
        public frmAdministradorMarcas()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marcas marca = new Marcas();
            try
            {
                if (txtAlta.Text == "")
                {
                    MessageBox.Show("Ingresar marca");
                    return;
                }
                marca.Descripcion = txtAlta.Text;
                marcaNegocio.agregar(marca);
                txtAlta.Text = "";
                cargarMarcas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marcas marcaSeleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que deseas eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    marcaSeleccionada = (Marcas)dgvMarcas.CurrentRow.DataBoundItem;
                    marcaNegocio.eliminar(marcaSeleccionada.Id);

                    cargarMarcas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmAdministradorMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                listaMarcas = marcaNegocio.listarMarcas();

                dgvMarcas.DataSource = listaMarcas;
                dgvMarcas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            Marcas marca = (Marcas)dgvMarcas.CurrentRow.DataBoundItem;
            txtEditar.Text = marca.Descripcion;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            Marcas marca = (Marcas)dgvMarcas.CurrentRow.DataBoundItem;
            marca.Descripcion = txtEditar.Text;

            marcaNegocio.editar(marca);
            txtEditar.Text = "";
            cargarMarcas();
        }

    }
}
