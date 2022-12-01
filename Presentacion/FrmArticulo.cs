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
    public partial class FrmArticulo : Form
    {
        List<Articulo> ListaArticulo = new List<Articulo>();
        public FrmArticulo()
        {
            InitializeComponent();
        }
       
        private void FrmArticulo_Load(object sender, EventArgs e)
        {
            cargar();
            cbxCampo.Items.Add("Codigo");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Precio");
        }
        
        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
       
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulo = negocio.Listar();
                dgvArticulo.DataSource = ListaArticulo;
                ocultarColumnas();
                cargarImagen(ListaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
        private void ocultarColumnas()
        {
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
        }
       
        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        
        private void tlsAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaArticulo ventana = new FrmAltaArticulo();
            ventana.ShowDialog();
            cargar();
        }
       
        private void tlsModificar_Click(object sender, EventArgs e)
        {

            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            FrmAltaArticulo modificar = new FrmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

        }
        
        private void tlsEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
       
        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            
            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");

            }
        }

        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio para filtrar");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debe ingresar un valor numerico ");
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Debe ingresar solo numeros ");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
       
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            
            try
            {
                if (validarFiltro())
                    return;
                
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TpFinal N°2 - MaxiPrograma \nDesarrollado por Federico Fogliatto ", "Acerca de",MessageBoxButtons.OK ,MessageBoxIcon.Information);
        }
    }
}
