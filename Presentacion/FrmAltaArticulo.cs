using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmAltaArticulo : Form
    {
        private Articulo articulo = null;
        
        public FrmAltaArticulo()
        {
            InitializeComponent();
        }
        
        public FrmAltaArticulo(Articulo Articulo)
        {
            InitializeComponent();
            this.articulo = Articulo;
            Text = "Modificar Articulo";
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txbCodigo.Text;
                articulo.Nombre = txbNombre.Text;
                articulo.Descripcion = txbDescripcion.Text;
                articulo.ImagenUrl = txbImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txbPrecio.Text);
                
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");

                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
       
        private void FrmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            try
            {
                cboCategoria.DataSource = categoria.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = marca.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txbCodigo.Text = articulo.Codigo;
                    txbNombre.Text = articulo.Nombre;
                    txbDescripcion.Text = articulo.Descripcion;
                    txbImagen.Text = articulo.ImagenUrl;
                    txbPrecio.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.ImagenUrl);
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
       
        private void txbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbImagen.Text);
        }

            
    }
}
