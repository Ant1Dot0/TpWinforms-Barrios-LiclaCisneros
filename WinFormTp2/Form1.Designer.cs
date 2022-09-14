namespace WinFormTp2
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripArticulos = new System.Windows.Forms.MenuStrip();
            this.agregarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarElArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUnArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStripArticulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripArticulos
            // 
            this.menuStripArticulos.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripArticulos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripArticulos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarArticuloToolStripMenuItem,
            this.modificarArticuloToolStripMenuItem,
            this.eliminarArticuloToolStripMenuItem,
            this.listadoDeArticulosToolStripMenuItem});
            this.menuStripArticulos.Location = new System.Drawing.Point(0, 0);
            this.menuStripArticulos.Name = "menuStripArticulos";
            this.menuStripArticulos.Size = new System.Drawing.Size(1098, 33);
            this.menuStripArticulos.TabIndex = 0;
            this.menuStripArticulos.Text = "Menu gestion articulos";
            // 
            // agregarArticuloToolStripMenuItem
            // 
            this.agregarArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoToolStripMenuItem});
            this.agregarArticuloToolStripMenuItem.Name = "agregarArticuloToolStripMenuItem";
            this.agregarArticuloToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.agregarArticuloToolStripMenuItem.Text = "Agregar Articulo";
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarNuevoToolStripMenuItem.Text = "Agregar nuevo";
            this.agregarNuevoToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoToolStripMenuItem_Click);
            // 
            // modificarArticuloToolStripMenuItem
            // 
            this.modificarArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarElArticuloToolStripMenuItem});
            this.modificarArticuloToolStripMenuItem.Name = "modificarArticuloToolStripMenuItem";
            this.modificarArticuloToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.modificarArticuloToolStripMenuItem.Text = "Modificar Articulo";
            // 
            // modificarElArticuloToolStripMenuItem
            // 
            this.modificarElArticuloToolStripMenuItem.Name = "modificarElArticuloToolStripMenuItem";
            this.modificarElArticuloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modificarElArticuloToolStripMenuItem.Text = "Modificar el articulo";
            // 
            // eliminarArticuloToolStripMenuItem
            // 
            this.eliminarArticuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarUnArticuloToolStripMenuItem,
            this.eliminarTodosToolStripMenuItem});
            this.eliminarArticuloToolStripMenuItem.Name = "eliminarArticuloToolStripMenuItem";
            this.eliminarArticuloToolStripMenuItem.Size = new System.Drawing.Size(156, 29);
            this.eliminarArticuloToolStripMenuItem.Text = "Eliminar Articulo";
            // 
            // eliminarUnArticuloToolStripMenuItem
            // 
            this.eliminarUnArticuloToolStripMenuItem.Name = "eliminarUnArticuloToolStripMenuItem";
            this.eliminarUnArticuloToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarUnArticuloToolStripMenuItem.Text = "Eliminar un articulo";
            // 
            // eliminarTodosToolStripMenuItem
            // 
            this.eliminarTodosToolStripMenuItem.Name = "eliminarTodosToolStripMenuItem";
            this.eliminarTodosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarTodosToolStripMenuItem.Text = "Eliminar todos";
            // 
            // listadoDeArticulosToolStripMenuItem
            // 
            this.listadoDeArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarTodosToolStripMenuItem,
            this.buscarPorMarcaToolStripMenuItem,
            this.buscarPorNombreToolStripMenuItem});
            this.listadoDeArticulosToolStripMenuItem.Name = "listadoDeArticulosToolStripMenuItem";
            this.listadoDeArticulosToolStripMenuItem.Size = new System.Drawing.Size(181, 29);
            this.listadoDeArticulosToolStripMenuItem.Text = "Listado de articulos";
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // buscarPorMarcaToolStripMenuItem
            // 
            this.buscarPorMarcaToolStripMenuItem.Name = "buscarPorMarcaToolStripMenuItem";
            this.buscarPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.buscarPorMarcaToolStripMenuItem.Text = "Buscar por marca";
            // 
            // buscarPorNombreToolStripMenuItem
            // 
            this.buscarPorNombreToolStripMenuItem.Name = "buscarPorNombreToolStripMenuItem";
            this.buscarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.buscarPorNombreToolStripMenuItem.Text = "Buscar por nombre";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1098, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 576);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripArticulos);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripArticulos;
            this.Name = "FrmPrincipal";
            this.Text = "Gestion de articulos";
            this.menuStripArticulos.ResumeLayout(false);
            this.menuStripArticulos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripArticulos;
        private System.Windows.Forms.ToolStripMenuItem agregarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarElArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUnArticuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorNombreToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

