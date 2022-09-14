using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTp2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof (FrmAgregar))//me devuelve el tipo de objeto qu ees
                {
                    MessageBox.Show("Ventana ya abierta ", "AVISO");
                    return;
                }
            }

            FrmAgregar ventana = new FrmAgregar();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmListar))//me devuelve el tipo de objeto qu ees
                {
                    MessageBox.Show("Ventana ya abierta ", "AVISO");
                    return;
                }
            }

            FrmListar ventana = new FrmListar();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
