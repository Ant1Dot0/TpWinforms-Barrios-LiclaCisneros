﻿using System;
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
                seleccionado = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
                negocio.eliminar(seleccionado.id);
                cargar();
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
                dgvEliminar.Columns["UrlImagen"].Visible = false;
                dgvEliminar.Columns["idmarca"].Visible = false;
                dgvEliminar.Columns["idCaegoria"].Visible = false;
                CargarImagen(listaArticulo[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void CargarImagen(string imagen)
        {
            try
            {
                pbEliminar.Load(imagen);
            }
            catch (Exception ex)
            {
                pbEliminar.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/681px-Placeholder_view_vector.svg.png");

            }
        }

        private void dgvEliminar_SelectionChanged(object sender, EventArgs e)
        {
            Articulo Seleccionado = (Articulo)dgvEliminar.CurrentRow.DataBoundItem;
            CargarImagen(Seleccionado.UrlImagen);
        }
    }
}
