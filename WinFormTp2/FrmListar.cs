using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinFormTp2
{
    public partial class FrmListar : Form
    {
        private List<Articulo> listaArticulo;
        public FrmListar()
        {
            InitializeComponent();
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {
            Cargar();
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Precio");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            Cargar();
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoria");
            cbCampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(artSeleccionado.UrlImagen);
            }
            
        }


        public void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                CargarImagen(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["idMarca"].Visible = false;
            dgvArticulos.Columns["idCaegoria"].Visible = false;
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbArticulo.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.cerrarConexion();
            this.Close();
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltro;
            string filtro = txtFiltro.Text;

            if (filtro.Length >= 2)
            {
                listaFiltro = listaArticulo.FindAll(item => item.Nombre.ToUpper().Contains(filtro.ToUpper()) || item.marca.descripcion.ToUpper().Contains(filtro.ToUpper()) || item.categoria.descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {

                listaFiltro = listaArticulo;

            }


            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltro;
            ocultarColumnas();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
            }
            else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Comienza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {


            ArticuloNegocio negocio = new ArticuloNegocio();



            try
            {
               // string campo = cbCampo.SelectedItem.ToString();
                //string criterio = cbCriterio.SelectedItem.ToString();
                //string filtro = txtFiltroAvanzado.Text;

                if (cbCampo.SelectedIndex != -1 && cbCampo.SelectedIndex != -1 && txtFiltroAvanzado.Text != "")
                {
                    string campo = cbCampo.SelectedItem.ToString();
                    string criterio = cbCriterio.SelectedItem.ToString();
                    string filtro = txtFiltroAvanzado.Text;
                    dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                }
                else
                {
                    if (txtFiltroAvanzado.Text == "")
                        txtFiltroAvanzado.BackColor = Color.Red;

                    MessageBox.Show("POR FAVOR CARGUE DATOS DE FILTRO");
                }
             
              
             

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void txtFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }
    }
}
