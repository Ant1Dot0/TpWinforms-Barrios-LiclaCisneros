namespace WinFormTp2
{
    partial class FrmListar
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
            this.lblListar = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListar.Location = new System.Drawing.Point(20, 23);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(188, 29);
            this.lblListar.TabIndex = 0;
            this.lblListar.Text = "Listar Articulos";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(12, 398);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(196, 40);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Mostrar Articulos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 68);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.Size = new System.Drawing.Size(762, 306);
            this.dgvArticulos.TabIndex = 2;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 457);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblListar);
            this.Name = "FrmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Articulos";
            this.Load += new System.EventHandler(this.FrmListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}