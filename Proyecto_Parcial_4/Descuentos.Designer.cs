
namespace Proyecto_Parcial_4
{
    partial class FMRDescuentos
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
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.DTGVDescuento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBTitle = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.LBTitle2 = new System.Windows.Forms.Label();
            this.TBDescuento = new System.Windows.Forms.TextBox();
            this.BTNActBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(389, 388);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 5;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // DTGVDescuento
            // 
            this.DTGVDescuento.AllowUserToAddRows = false;
            this.DTGVDescuento.AllowUserToDeleteRows = false;
            this.DTGVDescuento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVDescuento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Articulo,
            this.Marca,
            this.Descuento});
            this.DTGVDescuento.Location = new System.Drawing.Point(3, 96);
            this.DTGVDescuento.Name = "DTGVDescuento";
            this.DTGVDescuento.Size = new System.Drawing.Size(437, 150);
            this.DTGVDescuento.TabIndex = 22;
            this.DTGVDescuento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVDescuento_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Location = new System.Drawing.Point(168, 67);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(123, 13);
            this.LBTitle.TabIndex = 23;
            this.LBTitle.Text = "Artículos con descuento";
            // 
            // CBArticulo
            // 
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(44, 268);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(174, 21);
            this.CBArticulo.TabIndex = 0;
            this.CBArticulo.SelectedIndexChanged += new System.EventHandler(this.CBArticulo_SelectedIndexChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(251, 270);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(89, 21);
            this.BTNBuscar.TabIndex = 1;
            this.BTNBuscar.Text = "Buscar Artículo";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Enabled = false;
            this.BTNAgregar.Location = new System.Drawing.Point(265, 331);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregar.TabIndex = 4;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // LBTitle2
            // 
            this.LBTitle2.AutoSize = true;
            this.LBTitle2.Location = new System.Drawing.Point(41, 337);
            this.LBTitle2.Name = "LBTitle2";
            this.LBTitle2.Size = new System.Drawing.Size(59, 13);
            this.LBTitle2.TabIndex = 30;
            this.LBTitle2.Text = "Descuento";
            // 
            // TBDescuento
            // 
            this.TBDescuento.Enabled = false;
            this.TBDescuento.Location = new System.Drawing.Point(128, 334);
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.Size = new System.Drawing.Size(100, 20);
            this.TBDescuento.TabIndex = 3;
            // 
            // BTNActBusqueda
            // 
            this.BTNActBusqueda.Enabled = false;
            this.BTNActBusqueda.Location = new System.Drawing.Point(346, 268);
            this.BTNActBusqueda.Name = "BTNActBusqueda";
            this.BTNActBusqueda.Size = new System.Drawing.Size(118, 23);
            this.BTNActBusqueda.TabIndex = 2;
            this.BTNActBusqueda.Text = "Actualizar Busqueda";
            this.BTNActBusqueda.UseVisualStyleBackColor = true;
            this.BTNActBusqueda.Click += new System.EventHandler(this.BTNActBusqueda_Click);
            // 
            // FMRDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 414);
            this.ControlBox = false;
            this.Controls.Add(this.BTNActBusqueda);
            this.Controls.Add(this.TBDescuento);
            this.Controls.Add(this.LBTitle2);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.CBArticulo);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.DTGVDescuento);
            this.Controls.Add(this.BTNCerrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRDescuentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.FMRDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.DataGridView DTGVDescuento;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Label LBTitle2;
        private System.Windows.Forms.TextBox TBDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.Button BTNActBusqueda;
    }
}