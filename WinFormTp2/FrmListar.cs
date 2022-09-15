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
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            CargarImagen(listaArticulo[0].UrlImagen);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(artSeleccionado.UrlImagen);
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
    }
}
