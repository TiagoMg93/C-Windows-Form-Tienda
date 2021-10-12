
namespace Proyecto_Parcial_4
{
    partial class FRMVenta
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGVVenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBTitle = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.LBArticulo = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.LBCantidad = new System.Windows.Forms.Label();
            this.LBPrecio = new System.Windows.Forms.Label();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.TBDescuento = new System.Windows.Forms.TextBox();
            this.LBDescuento = new System.Windows.Forms.Label();
            this.LBSubtotal = new System.Windows.Forms.Label();
            this.TBSubtotal = new System.Windows.Forms.TextBox();
            this.BTNRegistrar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNLimpiar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNMostrar = new System.Windows.Forms.Button();
            this.LBTotal = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.salidaToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devolucionesToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.salidaToolStripMenuItem.Text = "Salida";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.descuentosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // DGVVenta
            // 
            this.DGVVenta.AllowUserToAddRows = false;
            this.DGVVenta.AllowUserToDeleteRows = false;
            this.DGVVenta.AllowUserToResizeColumns = false;
            this.DGVVenta.AllowUserToResizeRows = false;
            this.DGVVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Articulo,
            this.Marca,
            this.Precio_Unitario,
            this.Cantidad,
            this.Subtotal});
            this.DGVVenta.Location = new System.Drawing.Point(98, 77);
            this.DGVVenta.Name = "DGVVenta";
            this.DGVVenta.ReadOnly = true;
            this.DGVVenta.Size = new System.Drawing.Size(573, 150);
            this.DGVVenta.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 55;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Artículo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            this.Articulo.Width = 170;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 70;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.Width = 99;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 70;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 65;
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Location = new System.Drawing.Point(340, 40);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(91, 13);
            this.LBTitle.TabIndex = 2;
            this.LBTitle.Text = "Registro de venta";
            // 
            // CBArticulo
            // 
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(98, 254);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(315, 21);
            this.CBArticulo.TabIndex = 3;
            // 
            // LBArticulo
            // 
            this.LBArticulo.AutoSize = true;
            this.LBArticulo.Location = new System.Drawing.Point(38, 257);
            this.LBArticulo.Name = "LBArticulo";
            this.LBArticulo.Size = new System.Drawing.Size(44, 13);
            this.LBArticulo.TabIndex = 4;
            this.LBArticulo.Text = "Artículo";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(98, 294);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(49, 20);
            this.TBCantidad.TabIndex = 5;
            this.TBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBCantidad
            // 
            this.LBCantidad.AutoSize = true;
            this.LBCantidad.Location = new System.Drawing.Point(33, 297);
            this.LBCantidad.Name = "LBCantidad";
            this.LBCantidad.Size = new System.Drawing.Size(49, 13);
            this.LBCantidad.TabIndex = 6;
            this.LBCantidad.Text = "Cantidad";
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Location = new System.Drawing.Point(174, 297);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(37, 13);
            this.LBPrecio.TabIndex = 7;
            this.LBPrecio.Text = "Precio";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(217, 294);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(52, 20);
            this.TBPrecio.TabIndex = 8;
            this.TBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDescuento
            // 
            this.TBDescuento.Location = new System.Drawing.Point(366, 294);
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.ReadOnly = true;
            this.TBDescuento.Size = new System.Drawing.Size(47, 20);
            this.TBDescuento.TabIndex = 9;
            this.TBDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBDescuento
            // 
            this.LBDescuento.AutoSize = true;
            this.LBDescuento.Location = new System.Drawing.Point(301, 297);
            this.LBDescuento.Name = "LBDescuento";
            this.LBDescuento.Size = new System.Drawing.Size(59, 13);
            this.LBDescuento.TabIndex = 10;
            this.LBDescuento.Text = "Descuento";
            // 
            // LBSubtotal
            // 
            this.LBSubtotal.AutoSize = true;
            this.LBSubtotal.Location = new System.Drawing.Point(165, 336);
            this.LBSubtotal.Name = "LBSubtotal";
            this.LBSubtotal.Size = new System.Drawing.Size(46, 13);
            this.LBSubtotal.TabIndex = 11;
            this.LBSubtotal.Text = "Subtotal";
            // 
            // TBSubtotal
            // 
            this.TBSubtotal.Location = new System.Drawing.Point(217, 333);
            this.TBSubtotal.Name = "TBSubtotal";
            this.TBSubtotal.ReadOnly = true;
            this.TBSubtotal.Size = new System.Drawing.Size(52, 20);
            this.TBSubtotal.TabIndex = 12;
            this.TBSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.Location = new System.Drawing.Point(441, 252);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BTNRegistrar.TabIndex = 13;
            this.BTNRegistrar.Text = "Registrar";
            this.BTNRegistrar.UseVisualStyleBackColor = true;
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(596, 269);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 14;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Visible = false;
            // 
            // BTNLimpiar
            // 
            this.BTNLimpiar.Location = new System.Drawing.Point(441, 292);
            this.BTNLimpiar.Name = "BTNLimpiar";
            this.BTNLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNLimpiar.TabIndex = 15;
            this.BTNLimpiar.Text = "Limpiar";
            this.BTNLimpiar.UseVisualStyleBackColor = true;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(441, 331);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 16;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNMostrar
            // 
            this.BTNMostrar.Location = new System.Drawing.Point(596, 310);
            this.BTNMostrar.Name = "BTNMostrar";
            this.BTNMostrar.Size = new System.Drawing.Size(86, 23);
            this.BTNMostrar.TabIndex = 17;
            this.BTNMostrar.Text = "Mostrar Ventas";
            this.BTNMostrar.UseVisualStyleBackColor = true;
            this.BTNMostrar.Visible = false;
            // 
            // LBTotal
            // 
            this.LBTotal.AutoSize = true;
            this.LBTotal.Location = new System.Drawing.Point(530, 230);
            this.LBTotal.Name = "LBTotal";
            this.LBTotal.Size = new System.Drawing.Size(65, 13);
            this.LBTotal.TabIndex = 18;
            this.LBTotal.Text = "Total Venta:";
            // 
            // TBTotal
            // 
            this.TBTotal.Location = new System.Drawing.Point(596, 227);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(75, 20);
            this.TBTotal.TabIndex = 19;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(41, 331);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(93, 23);
            this.BTNBuscar.TabIndex = 20;
            this.BTNBuscar.Text = "Buscar Articulo";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            // 
            // FRMVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 375);
            this.ControlBox = false;
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.TBTotal);
            this.Controls.Add(this.LBTotal);
            this.Controls.Add(this.BTNMostrar);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNLimpiar);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNRegistrar);
            this.Controls.Add(this.TBSubtotal);
            this.Controls.Add(this.LBSubtotal);
            this.Controls.Add(this.LBDescuento);
            this.Controls.Add(this.TBDescuento);
            this.Controls.Add(this.TBPrecio);
            this.Controls.Add(this.LBPrecio);
            this.Controls.Add(this.LBCantidad);
            this.Controls.Add(this.TBCantidad);
            this.Controls.Add(this.LBArticulo);
            this.Controls.Add(this.CBArticulo);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.DGVVenta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FRMVenta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView DGVVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Label LBArticulo;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.Label LBCantidad;
        private System.Windows.Forms.Label LBPrecio;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.TextBox TBDescuento;
        private System.Windows.Forms.Label LBDescuento;
        private System.Windows.Forms.Label LBSubtotal;
        private System.Windows.Forms.TextBox TBSubtotal;
        private System.Windows.Forms.Button BTNRegistrar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNLimpiar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNMostrar;
        private System.Windows.Forms.Label LBTotal;
        private System.Windows.Forms.TextBox TBTotal;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
    }
}

