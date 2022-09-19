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
    public partial class FrmEliminar : Form
    {
        List<Articulo> listaArticulo = new List<Articulo>();
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminarFisica_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = new Articulo();

            try
            {
                DialogResult resp=MessageBox.Show("El articulo va a eliminarse¿Desea continuar?","Eliminar articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(resp == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.id);
                    cargar();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEliminar_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvEliminar.DataSource = listaArticulo;
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
            dgvEliminar.Columns["id"].Visible = false;
            dgvEliminar.Columns["UrlImagen"].Visible = false;
            dgvEliminar.Columns["idmarca"].Visible = false;
            dgvEliminar.Columns["idCaegoria"].Visible = false;
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbEliminar.Load(imagen);
            }
            catch (Exception ex)
            {
                pbEliminar.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpeNtHuazDuKjPKkrRg9HSrip4rY8U9qbW_CNoOU6sfg&s");

            }
        }

        private void dgvEliminar_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvEliminar.CurrentRow != null)
            {
                Articulo Seleccionado = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
                CargarImagen(Seleccionado.UrlImagen);
            }
        
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltro;
            string filtro = txtFiltrar.Text;

            if (filtro.Length >= 2)
            {
                listaFiltro = listaArticulo.FindAll(item => item.Nombre.ToUpper().Contains(filtro.ToUpper()) || item.marca.descripcion.ToUpper().Contains(filtro.ToUpper()) || item.categoria.descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {

                listaFiltro = listaArticulo;

            }


            dgvEliminar.DataSource = null;
            dgvEliminar.DataSource = listaFiltro;
            ocultarColumnas();
        }
    }
}
