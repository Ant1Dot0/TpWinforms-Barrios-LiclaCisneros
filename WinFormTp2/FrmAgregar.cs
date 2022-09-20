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
        private Articulo articulo = null;
        public FrmAgregar()
        {
            InitializeComponent();
        }

        public FrmAgregar(Articulo articulo)
        {

            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Pokemon";
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
            
            ArticuloNegocio negocio = new ArticuloNegocio(); 
            try
            {
                if(txtbCodigo.Text != "" && txtbNombre.Text != "" && txtbPrecio.Text  != "")
                {
                    if (articulo == null)
                        articulo = new Articulo();

                    articulo.codigo = txtbCodigo.Text;
                    articulo.Nombre = txtbNombre.Text;
                    articulo.Descripcion = txtbDescripcion.Text;
                    articulo.UrlImagen = txtbUrl.Text;
                    articulo.Precio = decimal.Parse(txtbPrecio.Text);
                    articulo.marca = (Marca)cbxMarca.SelectedItem;
                    articulo.categoria = (Categoria)cbxCategoria.SelectedItem;

                    if (articulo.id != 0)
                    {
                        negocio.modificar(articulo);
                        MessageBox.Show("Modificado con exito");
                    }
                    else
                    {
                        negocio.agregar(articulo);
                        MessageBox.Show("Agregado con exito");

                    }

                    this.Close();
                }

                else
                {
                    txtbPrecio.BackColor = Color.Red;
                    txtbNombre.BackColor = Color.Red;
                    txtbCodigo.BackColor = Color.Red;
                    MessageBox.Show("Por favor cargue Nombre, Codigo y Precio","ATENCION ");
                }


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
                cbxMarca.ValueMember = "id";
                cbxMarca.DisplayMember = "descripcion";

                cbxCategoria.DataSource = catNegocio.listar();
                cbxCategoria.ValueMember = "cod";
                cbxCategoria.DisplayMember = "descripcion";


                if(articulo != null)
                {
                    txtbCodigo.Text = articulo.codigo;
                    txtbDescripcion.Text = articulo.Descripcion;
                    txtbNombre.Text = articulo.Nombre;
                   
                    txtbUrl.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);

                    txtbPrecio.Text = articulo.Precio.ToString();

                    cbxCategoria.SelectedValue = articulo.categoria.cod;
                    cbxMarca.SelectedValue = articulo.marca.id;



                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbUrlImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbUrlImagen.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");
            }
        }

        private void txtbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            
        }
    }
}
