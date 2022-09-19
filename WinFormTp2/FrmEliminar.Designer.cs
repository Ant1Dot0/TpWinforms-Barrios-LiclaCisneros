namespace WinFormTp2
{
    partial class FrmEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEliminarFisica = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.pbEliminar = new System.Windows.Forms.PictureBox();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarFisica
            // 
            this.btnEliminarFisica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarFisica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarFisica.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFisica.Location = new System.Drawing.Point(113, 495);
            this.btnEliminarFisica.Name = "btnEliminarFisica";
            this.btnEliminarFisica.Size = new System.Drawing.Size(133, 53);
            this.btnEliminarFisica.TabIndex = 1;
            this.btnEliminarFisica.Text = "Eliminar";
            this.btnEliminarFisica.UseVisualStyleBackColor = false;
            this.btnEliminarFisica.Click += new System.EventHandler(this.btnEliminarFisica_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(711, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 52);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEliminar.Location = new System.Drawing.Point(53, 129);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.RowHeadersWidth = 62;
            this.dgvEliminar.RowTemplate.Height = 28;
            this.dgvEliminar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminar.Size = new System.Drawing.Size(875, 349);
            this.dgvEliminar.TabIndex = 4;
            this.dgvEliminar.SelectionChanged += new System.EventHandler(this.dgvEliminar_SelectionChanged);
            // 
            // pbEliminar
            // 
            this.pbEliminar.Location = new System.Drawing.Point(972, 178);
            this.pbEliminar.Name = "pbEliminar";
            this.pbEliminar.Size = new System.Drawing.Size(265, 270);
            this.pbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEliminar.TabIndex = 5;
            this.pbEliminar.TabStop = false;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(403, 25);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(184, 27);
            this.lblEliminar.TabIndex = 6;
            this.lblEliminar.Text = "Eliminar articulo";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(49, 84);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(76, 21);
            this.lblFiltrar.TabIndex = 7;
            this.lblFiltrar.Text = "Buscar: ";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Location = new System.Drawing.Point(152, 81);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(194, 28);
            this.txtFiltrar.TabIndex = 8;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // FrmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 569);
            this.Controls.Add(this.txtFiltrar);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.pbEliminar);
            this.Controls.Add(this.dgvEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminarFisica);
            this.Name = "FrmEliminar";
            this.Text = "Eliminar Articulos";
            this.Load += new System.EventHandler(this.FrmEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEliminarFisica;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.PictureBox pbEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtFiltrar;
    }
}