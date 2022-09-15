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
    public partial class FrmAgregar : Form
    {
        public FrmAgregar()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio(); 
            try
            {
                articulo.codigo = txtbCodigo.Text;
                articulo.Nombre = txtbNombre.Text;
                articulo.Descripcion = txtbDescripcion.Text;
                articulo.UrlImagen = txtbUrl.Text;
                articulo.Precio = decimal.Parse(txtbPrecio.Text);
                articulo.marca = (Marca)cbxMarca.SelectedItem;
                articulo.categoria =(Categoria)cbxCategoria.SelectedItem; 

                negocio.agregar(articulo);
                MessageBox.Show("Agregado con exito");
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marNegocio = new MarcaNegocio();
            CategoriaNegocio catNegocio = new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marNegocio.listar();
                cbxCategoria.DataSource = catNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
