
namespace Proyecto_Parcial_4
{
    partial class FMRProveedores
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBTitle = new System.Windows.Forms.Label();
            this.LBTitle2 = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.LBTitle3 = new System.Windows.Forms.Label();
            this.TBUnidades = new System.Windows.Forms.TextBox();
            this.LBUnidades = new System.Windows.Forms.Label();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.LBTitle4 = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.LBCodigo = new System.Windows.Forms.Label();
            this.LBArticulo = new System.Windows.Forms.Label();
            this.LBPrecio = new System.Windows.Forms.Label();
            this.LBCosto = new System.Windows.Forms.Label();
            this.TBCosto = new System.Windows.Forms.TextBox();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.LBCantidad = new System.Windows.Forms.Label();
            this.TBMarca = new System.Windows.Forms.TextBox();
            this.TBContacto = new System.Windows.Forms.TextBox();
            this.LBMarca = new System.Windows.Forms.Label();
            this.LBProveedor = new System.Windows.Forms.Label();
            this.LBContacto = new System.Windows.Forms.Label();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.BTNActBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articulo,
            this.Marca,
            this.Contacto});
            this.dataGridView1.Location = new System.Drawing.Point(347, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(340, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Location = new System.Drawing.Point(445, 18);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(120, 13);
            this.LBTitle.TabIndex = 2;
            this.LBTitle.Text = "Artículos sin existencias";
            // 
            // LBTitle2
            // 
            this.LBTitle2.AutoSize = true;
            this.LBTitle2.Location = new System.Drawing.Point(125, 18);
            this.LBTitle2.Name = "LBTitle2";
            this.LBTitle2.Size = new System.Drawing.Size(110, 13);
            this.LBTitle2.TabIndex = 3;
            this.LBTitle2.Text = "Ingreso de Mercancia";
            // 
            // CBArticulo
            // 
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(20, 88);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(174, 21);
            this.CBArticulo.TabIndex = 4;
            this.CBArticulo.SelectedIndexChanged += new System.EventHandler(this.CBArticulo_SelectedIndexChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(222, 73);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(89, 21);
            this.BTNBuscar.TabIndex = 5;
            this.BTNBuscar.Text = "Buscar Artículo";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // LBTitle3
            // 
            this.LBTitle3.AutoSize = true;
            this.LBTitle3.Location = new System.Drawing.Point(134, 43);
            this.LBTitle3.Name = "LBTitle3";
            this.LBTitle3.Size = new System.Drawing.Size(101, 13);
            this.LBTitle3.TabIndex = 6;
            this.LBTitle3.Text = "Articulo ya existente";
            // 
            // TBUnidades
            // 
            this.TBUnidades.Location = new System.Drawing.Point(146, 148);
            this.TBUnidades.Name = "TBUnidades";
            this.TBUnidades.Size = new System.Drawing.Size(100, 20);
            this.TBUnidades.TabIndex = 7;
            this.TBUnidades.TextChanged += new System.EventHandler(this.TBUnidades_TextChanged);
            // 
            // LBUnidades
            // 
            this.LBUnidades.AutoSize = true;
            this.LBUnidades.Location = new System.Drawing.Point(91, 151);
            this.LBUnidades.Name = "LBUnidades";
            this.LBUnidades.Size = new System.Drawing.Size(49, 13);
            this.LBUnidades.TabIndex = 8;
            this.LBUnidades.Text = "Cantidad";
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(160, 174);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(75, 23);
            this.BTNActualizar.TabIndex = 9;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // LBTitle4
            // 
            this.LBTitle4.AutoSize = true;
            this.LBTitle4.Location = new System.Drawing.Point(229, 218);
            this.LBTitle4.Name = "LBTitle4";
            this.LBTitle4.Size = new System.Drawing.Size(77, 13);
            this.LBTitle4.TabIndex = 10;
            this.LBTitle4.Text = "Artículo nuevo";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Enabled = false;
            this.TBCodigo.Location = new System.Drawing.Point(94, 252);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.ReadOnly = true;
            this.TBCodigo.Size = new System.Drawing.Size(100, 20);
            this.TBCodigo.TabIndex = 11;
            // 
            // TBArticulo
            // 
            this.TBArticulo.Location = new System.Drawing.Point(298, 252);
            this.TBArticulo.Name = "TBArticulo";
            this.TBArticulo.Size = new System.Drawing.Size(100, 20);
            this.TBArticulo.TabIndex = 12;
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(94, 290);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(100, 20);
            this.TBPrecio.TabIndex = 13;
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Location = new System.Drawing.Point(36, 255);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(40, 13);
            this.LBCodigo.TabIndex = 14;
            this.LBCodigo.Text = "Código";
            // 
            // LBArticulo
            // 
            this.LBArticulo.AutoSize = true;
            this.LBArticulo.Location = new System.Drawing.Point(235, 255);
            this.LBArticulo.Name = "LBArticulo";
            this.LBArticulo.Size = new System.Drawing.Size(44, 13);
            this.LBArticulo.TabIndex = 15;
            this.LBArticulo.Text = "Artículo";
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Location = new System.Drawing.Point(12, 293);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(76, 13);
            this.LBPrecio.TabIndex = 16;
            this.LBPrecio.Text = "Precio Unitario";
            // 
            // LBCosto
            // 
            this.LBCosto.AutoSize = true;
            this.LBCosto.Location = new System.Drawing.Point(219, 293);
            this.LBCosto.Name = "LBCosto";
            this.LBCosto.Size = new System.Drawing.Size(73, 13);
            this.LBCosto.TabIndex = 17;
            this.LBCosto.Text = "Costo Unitario";
            // 
            // TBCosto
            // 
            this.TBCosto.Location = new System.Drawing.Point(298, 290);
            this.TBCosto.Name = "TBCosto";
            this.TBCosto.Size = new System.Drawing.Size(100, 20);
            this.TBCosto.TabIndex = 18;
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(94, 328);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(100, 20);
            this.TBCantidad.TabIndex = 19;
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(94, 366);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(100, 20);
            this.TBProveedor.TabIndex = 20;
            // 
            // LBCantidad
            // 
            this.LBCantidad.AutoSize = true;
            this.LBCantidad.Location = new System.Drawing.Point(27, 331);
            this.LBCantidad.Name = "LBCantidad";
            this.LBCantidad.Size = new System.Drawing.Size(49, 13);
            this.LBCantidad.TabIndex = 21;
            this.LBCantidad.Text = "Cantidad";
            // 
            // TBMarca
            // 
            this.TBMarca.Location = new System.Drawing.Point(298, 328);
            this.TBMarca.Name = "TBMarca";
            this.TBMarca.Size = new System.Drawing.Size(100, 20);
            this.TBMarca.TabIndex = 22;
            // 
            // TBContacto
            // 
            this.TBContacto.Location = new System.Drawing.Point(298, 366);
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.Size = new System.Drawing.Size(100, 20);
            this.TBContacto.TabIndex = 23;
            // 
            // LBMarca
            // 
            this.LBMarca.AutoSize = true;
            this.LBMarca.Location = new System.Drawing.Point(235, 331);
            this.LBMarca.Name = "LBMarca";
            this.LBMarca.Size = new System.Drawing.Size(37, 13);
            this.LBMarca.TabIndex = 24;
            this.LBMarca.Text = "Marca";
            // 
            // LBProveedor
            // 
            this.LBProveedor.AutoSize = true;
            this.LBProveedor.Location = new System.Drawing.Point(27, 369);
            this.LBProveedor.Name = "LBProveedor";
            this.LBProveedor.Size = new System.Drawing.Size(56, 13);
            this.LBProveedor.TabIndex = 25;
            this.LBProveedor.Text = "Proveedor";
            // 
            // LBContacto
            // 
            this.LBContacto.AutoSize = true;
            this.LBContacto.Location = new System.Drawing.Point(229, 369);
            this.LBContacto.Name = "LBContacto";
            this.LBContacto.Size = new System.Drawing.Size(50, 13);
            this.LBContacto.TabIndex = 26;
            this.LBContacto.Text = "Contacto";
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(466, 288);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregar.TabIndex = 27;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(466, 325);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNLimpiar.TabIndex = 28;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            this.BTNLimpiar.Click += new System.EventHandler(this.BTNLimpiar_Click);
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(612, 383);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 29;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // BTNActBusqueda
            // 
            this.BTNActBusqueda.Enabled = false;
            this.BTNActBusqueda.Location = new System.Drawing.Point(212, 100);
            this.BTNActBusqueda.Name = "BTNActBusqueda";
            this.BTNActBusqueda.Size = new System.Drawing.Size(118, 23);
            this.BTNActBusqueda.TabIndex = 30;
            this.BTNActBusqueda.Text = "Actualizar Busqueda";
            this.BTNActBusqueda.UseVisualStyleBackColor = true;
            this.BTNActBusqueda.Click += new System.EventHandler(this.BTNActBusqueda_Click);
            // 
            // FMRProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 418);
            this.ControlBox = false;
            this.Controls.Add(this.BTNActBusqueda);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.LBContacto);
            this.Controls.Add(this.LBProveedor);
            this.Controls.Add(this.LBMarca);
            this.Controls.Add(this.TBContacto);
            this.Controls.Add(this.TBMarca);
            this.Controls.Add(this.LBCantidad);
            this.Controls.Add(this.TBProveedor);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.TBCosto);
            this.Controls.Add(this.LBCosto);
            this.Controls.Add(this.LBPrecio);
            this.Controls.Add(this.LBArticulo);
            this.Controls.Add(this.LBCodigo);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.TBArticulo);
            this.Controls.Add(this.TBCodigo);
            this.Controls.Add(this.LBTitle4);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.LBUnidades);
            this.Controls.Add(this.TBUnidades);
            this.Controls.Add(this.LBTitle3);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.CBArticulo);
            this.Controls.Add(this.LBTitle2);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FMRProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.Label LBTitle2;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Label LBTitle3;
        private System.Windows.Forms.TextBox TBUnidades;
        private System.Windows.Forms.Label LBUnidades;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Label LBTitle4;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.TextBox TBArticulo;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.Label LBArticulo;
        private System.Windows.Forms.Label LBPrecio;
        private System.Windows.Forms.Label LBCosto;
        private System.Windows.Forms.TextBox TBCosto;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.Label LBCantidad;
        private System.Windows.Forms.TextBox TBMarca;
        private System.Windows.Forms.TextBox TBContacto;
        private System.Windows.Forms.Label LBMarca;
        private System.Windows.Forms.Label LBProveedor;
        private System.Windows.Forms.Label LBContacto;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.Button BTNActBusqueda;
    }
}