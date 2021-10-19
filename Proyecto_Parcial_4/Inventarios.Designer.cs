
namespace Proyecto_Parcial_4
{
    partial class FMRInventarios
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
            this.DTGVInventario = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.LBCodigo = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.LBPrecio = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.LBCosto = new System.Windows.Forms.Label();
            this.TBCosto = new System.Windows.Forms.TextBox();
            this.LBCantidad = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.LBMarca = new System.Windows.Forms.Label();
            this.TBMarca = new System.Windows.Forms.TextBox();
            this.LBProveedor = new System.Windows.Forms.Label();
            this.TBProveedor = new System.Windows.Forms.TextBox();
            this.LBContacto = new System.Windows.Forms.Label();
            this.TBContacto = new System.Windows.Forms.TextBox();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.BTNActBusqueda = new System.Windows.Forms.Button();
            this.LBArticulo = new System.Windows.Forms.Label();
            this.TBArticulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVInventario
            // 
            this.DTGVInventario.AllowUserToAddRows = false;
            this.DTGVInventario.AllowUserToDeleteRows = false;
            this.DTGVInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Articulo,
            this.Precio_Unitario,
            this.Costo,
            this.Marca,
            this.Cantidad,
            this.Proveedor,
            this.Contacto});
            this.DTGVInventario.Location = new System.Drawing.Point(12, 12);
            this.DTGVInventario.Name = "DTGVInventario";
            this.DTGVInventario.ReadOnly = true;
            this.DTGVInventario.Size = new System.Drawing.Size(821, 221);
            this.DTGVInventario.TabIndex = 1;
            this.DTGVInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVInventario_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo Unitario";
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.Name = "Contacto";
            this.Contacto.ReadOnly = true;
            // 
            // CBArticulo
            // 
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(54, 252);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(174, 21);
            this.CBArticulo.TabIndex = 5;
            this.CBArticulo.SelectedIndexChanged += new System.EventHandler(this.CBArticulo_SelectedIndexChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(254, 252);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(89, 21);
            this.BTNBuscar.TabIndex = 6;
            this.BTNBuscar.Text = "Buscar Artículo";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // LBCodigo
            // 
            this.LBCodigo.AutoSize = true;
            this.LBCodigo.Location = new System.Drawing.Point(72, 294);
            this.LBCodigo.Name = "LBCodigo";
            this.LBCodigo.Size = new System.Drawing.Size(40, 13);
            this.LBCodigo.TabIndex = 15;
            this.LBCodigo.Text = "Código";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Enabled = false;
            this.TBCodigo.Location = new System.Drawing.Point(128, 291);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(100, 20);
            this.TBCodigo.TabIndex = 16;
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Location = new System.Drawing.Point(36, 332);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(76, 13);
            this.LBPrecio.TabIndex = 17;
            this.LBPrecio.Text = "Precio Unitario";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(128, 329);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(100, 20);
            this.TBPrecio.TabIndex = 18;
            // 
            // LBCosto
            // 
            this.LBCosto.AutoSize = true;
            this.LBCosto.Location = new System.Drawing.Point(39, 371);
            this.LBCosto.Name = "LBCosto";
            this.LBCosto.Size = new System.Drawing.Size(73, 13);
            this.LBCosto.TabIndex = 19;
            this.LBCosto.Text = "Costo Unitario";
            // 
            // TBCosto
            // 
            this.TBCosto.Location = new System.Drawing.Point(128, 368);
            this.TBCosto.Name = "TBCosto";
            this.TBCosto.Size = new System.Drawing.Size(100, 20);
            this.TBCosto.TabIndex = 20;
            // 
            // LBCantidad
            // 
            this.LBCantidad.AutoSize = true;
            this.LBCantidad.Location = new System.Drawing.Point(294, 332);
            this.LBCantidad.Name = "LBCantidad";
            this.LBCantidad.Size = new System.Drawing.Size(49, 13);
            this.LBCantidad.TabIndex = 22;
            this.LBCantidad.Text = "Cantidad";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Enabled = false;
            this.TBCantidad.Location = new System.Drawing.Point(367, 329);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(100, 20);
            this.TBCantidad.TabIndex = 23;
            // 
            // LBMarca
            // 
            this.LBMarca.AutoSize = true;
            this.LBMarca.Location = new System.Drawing.Point(306, 371);
            this.LBMarca.Name = "LBMarca";
            this.LBMarca.Size = new System.Drawing.Size(37, 13);
            this.LBMarca.TabIndex = 25;
            this.LBMarca.Text = "Marca";
            // 
            // TBMarca
            // 
            this.TBMarca.Location = new System.Drawing.Point(367, 368);
            this.TBMarca.Name = "TBMarca";
            this.TBMarca.Size = new System.Drawing.Size(100, 20);
            this.TBMarca.TabIndex = 26;
            // 
            // LBProveedor
            // 
            this.LBProveedor.AutoSize = true;
            this.LBProveedor.Location = new System.Drawing.Point(518, 294);
            this.LBProveedor.Name = "LBProveedor";
            this.LBProveedor.Size = new System.Drawing.Size(56, 13);
            this.LBProveedor.TabIndex = 27;
            this.LBProveedor.Text = "Proveedor";
            // 
            // TBProveedor
            // 
            this.TBProveedor.Location = new System.Drawing.Point(595, 291);
            this.TBProveedor.Name = "TBProveedor";
            this.TBProveedor.Size = new System.Drawing.Size(100, 20);
            this.TBProveedor.TabIndex = 28;
            // 
            // LBContacto
            // 
            this.LBContacto.AutoSize = true;
            this.LBContacto.Location = new System.Drawing.Point(524, 332);
            this.LBContacto.Name = "LBContacto";
            this.LBContacto.Size = new System.Drawing.Size(50, 13);
            this.LBContacto.TabIndex = 29;
            this.LBContacto.Text = "Contacto";
            // 
            // TBContacto
            // 
            this.TBContacto.Location = new System.Drawing.Point(595, 329);
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.Size = new System.Drawing.Size(100, 20);
            this.TBContacto.TabIndex = 30;
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(611, 366);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(75, 23);
            this.BTNModificar.TabIndex = 31;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(758, 377);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 32;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // BTNActBusqueda
            // 
            this.BTNActBusqueda.Enabled = false;
            this.BTNActBusqueda.Location = new System.Drawing.Point(349, 250);
            this.BTNActBusqueda.Name = "BTNActBusqueda";
            this.BTNActBusqueda.Size = new System.Drawing.Size(118, 23);
            this.BTNActBusqueda.TabIndex = 33;
            this.BTNActBusqueda.Text = "Actualizar Busqueda";
            this.BTNActBusqueda.UseVisualStyleBackColor = true;
            this.BTNActBusqueda.Click += new System.EventHandler(this.BTNActBusqueda_Click);
            // 
            // LBArticulo
            // 
            this.LBArticulo.AutoSize = true;
            this.LBArticulo.Location = new System.Drawing.Point(299, 294);
            this.LBArticulo.Name = "LBArticulo";
            this.LBArticulo.Size = new System.Drawing.Size(44, 13);
            this.LBArticulo.TabIndex = 34;
            this.LBArticulo.Text = "Artículo";
            // 
            // TBArticulo
            // 
            this.TBArticulo.Location = new System.Drawing.Point(367, 291);
            this.TBArticulo.Name = "TBArticulo";
            this.TBArticulo.Size = new System.Drawing.Size(100, 20);
            this.TBArticulo.TabIndex = 35;
            // 
            // FMRInventarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 412);
            this.ControlBox = false;
            this.Controls.Add(this.TBArticulo);
            this.Controls.Add(this.LBArticulo);
            this.Controls.Add(this.BTNActBusqueda);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.TBContacto);
            this.Controls.Add(this.LBContacto);
            this.Controls.Add(this.TBProveedor);
            this.Controls.Add(this.LBProveedor);
            this.Controls.Add(this.TBMarca);
            this.Controls.Add(this.LBMarca);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.LBCantidad);
            this.Controls.Add(this.TBCosto);
            this.Controls.Add(this.LBCosto);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.LBPrecio);
            this.Controls.Add(this.TBCodigo);
            this.Controls.Add(this.LBCodigo);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.CBArticulo);
            this.Controls.Add(this.DTGVInventario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRInventarios";
            this.Text = "Inventarios";
            this.Load += new System.EventHandler(this.FMRInventarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGVInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVInventario;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Label LBCodigo;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label LBPrecio;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label LBCosto;
        private System.Windows.Forms.TextBox TBCosto;
        private System.Windows.Forms.Label LBCantidad;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.Label LBMarca;
        private System.Windows.Forms.TextBox TBMarca;
        private System.Windows.Forms.Label LBProveedor;
        private System.Windows.Forms.TextBox TBProveedor;
        private System.Windows.Forms.Label LBContacto;
        private System.Windows.Forms.TextBox TBContacto;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
        private System.Windows.Forms.Button BTNActBusqueda;
        private System.Windows.Forms.Label LBArticulo;
        private System.Windows.Forms.TextBox TBArticulo;
    }
}