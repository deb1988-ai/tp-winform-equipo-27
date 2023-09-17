using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_equipo_27
{
    public partial class frmArticuloAlta : Form
    {
        private Articulo articulo = null;
        public frmArticuloAlta()
        {
            InitializeComponent();
        }

        public frmArticuloAlta(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
            this.Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ListaImagenes = cboImagenes.Items.Cast<Imagenes>().ToList();
                articulo.Marca = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {
                    articuloNegocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    articuloNegocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            ImagenesNegocio imagenesNegocio = new ImagenesNegocio();

           
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.DataSource = marcaNegocio.listarMarcas();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    cboImagenes.DataSource = imagenesNegocio.listarImagenes(articulo.Id);
                    cboImagenes.ValueMember = "Id";
                    cboImagenes.DisplayMember = "ImagenUrl";

                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();

                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboImagenes.SelectedValue = articulo.ListaImagenes[0].Id;
                    cargarImagen(articulo.ListaImagenes[0].ImagenUrl);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void cboImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imagenes imagenSeleccionada = (Imagenes)cboImagenes.SelectedItem;
            cargarImagen(imagenSeleccionada.ImagenUrl);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            Imagenes imagen = new Imagenes();

            imagen.ImagenUrl = txtUrlImagen.Text;
            
            List<Imagenes> listaImagenes = new List<Imagenes>();
            listaImagenes = cboImagenes.Items.Cast<Imagenes>().ToList();

            listaImagenes.Add(imagen);
            cboImagenes.DataSource = listaImagenes;
            cboImagenes.DisplayMember = "ImagenUrl";

            cboImagenes.SelectedItem = imagen.ImagenUrl;

            txtUrlImagen.Text = "";
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            Imagenes imagen = (Imagenes)cboImagenes.SelectedItem;
            ImagenesNegocio imagenesNegocio = new ImagenesNegocio();

            imagenesNegocio.eliminar(imagen.ImagenUrl);

            List<Imagenes> listaImagenes = new List<Imagenes>();
            listaImagenes = cboImagenes.Items.Cast<Imagenes>().ToList();

            listaImagenes.Remove(imagen);
            
            cboImagenes.DataSource= listaImagenes;
            cboImagenes.DisplayMember = "ImagenUrl";
        }
    }
}
