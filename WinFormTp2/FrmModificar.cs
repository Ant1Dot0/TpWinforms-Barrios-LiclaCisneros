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
    public partial class FrmModificar : Form
    {
        List<Articulo> listaArticulo = new List<Articulo>();
        public FrmModificar()
        {
            InitializeComponent();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbModificar.Load(imagen);
            }
            catch (Exception ex)
            {
                pbModificar.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado;

            artSeleccionado = (Articulo)dgvModificar.CurrentRow.DataBoundItem;

            FrmAgregar modificar = new FrmAgregar(artSeleccionado);
            modificar.ShowDialog();
            Cargar();

        }

        public void Cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvModificar.DataSource = listaArticulo;
                dgvModificar.Columns["UrlImagen"].Visible = false;
                dgvModificar.Columns["idmarca"].Visible = false;
                dgvModificar.Columns["idCaegoria"].Visible = false;
                CargarImagen(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvModificar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo artSeleccionado = (Articulo)dgvModificar.CurrentRow.DataBoundItem;
            CargarImagen(artSeleccionado.UrlImagen);
        }

        private void dgvModificar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
