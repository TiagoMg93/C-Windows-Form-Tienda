
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
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNMostrar = new System.Windows.Forms.Button();
            this.LBTotal = new System.Windows.Forms.Label();
            this.TBTotal = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNActBusqueda = new System.Windows.Forms.Button();
            this.BTNCalcular = new System.Windows.Forms.Button();
            this.LBPago = new System.Windows.Forms.Label();
            this.TBPago = new System.Windows.Forms.TextBox();
            this.BTNConfirmar = new System.Windows.Forms.Button();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.LBCambio = new System.Windows.Forms.Label();
            this.TBCambio = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem});
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devolucionesToolStripMenuItem});
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salidaToolStripMenuItem.Text = "Salida";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            this.devolucionesToolStripMenuItem.Click += new System.EventHandler(this.devolucionesToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Click += new System.EventHandler(this.inventarioToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.descuentosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // descuentosToolStripMenuItem
            // 
            this.descuentosToolStripMenuItem.Name = "descuentosToolStripMenuItem";
            this.descuentosToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.descuentosToolStripMenuItem.Text = "Descuentos";
            this.descuentosToolStripMenuItem.Click += new System.EventHandler(this.descuentosToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
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
            this.Descuento,
            this.Cantidad,
            this.Subtotal});
            this.DGVVenta.Location = new System.Drawing.Point(35, 82);
            this.DGVVenta.Name = "DGVVenta";
            this.DGVVenta.ReadOnly = true;
            this.DGVVenta.Size = new System.Drawing.Size(634, 171);
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
            this.Articulo.Width = 120;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 110;
            // 
            // Precio_Unitario
            // 
            this.Precio_Unitario.HeaderText = "Precio Unitario ($)";
            this.Precio_Unitario.Name = "Precio_Unitario";
            this.Precio_Unitario.ReadOnly = true;
            this.Precio_Unitario.Width = 90;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento por unidad ($)";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 80;
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
            this.LBTitle.Location = new System.Drawing.Point(303, 66);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(91, 13);
            this.LBTitle.TabIndex = 2;
            this.LBTitle.Text = "Registro de venta";
            // 
            // CBArticulo
            // 
            this.CBArticulo.Enabled = false;
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(64, 280);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(315, 21);
            this.CBArticulo.TabIndex = 0;
            this.CBArticulo.SelectedIndexChanged += new System.EventHandler(this.CBArticulo_SelectedIndexChanged);
            // 
            // LBArticulo
            // 
            this.LBArticulo.AutoSize = true;
            this.LBArticulo.Location = new System.Drawing.Point(4, 283);
            this.LBArticulo.Name = "LBArticulo";
            this.LBArticulo.Size = new System.Drawing.Size(44, 13);
            this.LBArticulo.TabIndex = 4;
            this.LBArticulo.Text = "Artículo";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Enabled = false;
            this.TBCantidad.Location = new System.Drawing.Point(64, 320);
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(49, 20);
            this.TBCantidad.TabIndex = 1;
            this.TBCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBCantidad
            // 
            this.LBCantidad.AutoSize = true;
            this.LBCantidad.Location = new System.Drawing.Point(9, 323);
            this.LBCantidad.Name = "LBCantidad";
            this.LBCantidad.Size = new System.Drawing.Size(49, 13);
            this.LBCantidad.TabIndex = 6;
            this.LBCantidad.Text = "Cantidad";
            // 
            // LBPrecio
            // 
            this.LBPrecio.AutoSize = true;
            this.LBPrecio.Location = new System.Drawing.Point(140, 323);
            this.LBPrecio.Name = "LBPrecio";
            this.LBPrecio.Size = new System.Drawing.Size(37, 13);
            this.LBPrecio.TabIndex = 7;
            this.LBPrecio.Text = "Precio";
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(183, 320);
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.ReadOnly = true;
            this.TBPrecio.Size = new System.Drawing.Size(52, 20);
            this.TBPrecio.TabIndex = 2;
            this.TBPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDescuento
            // 
            this.TBDescuento.Location = new System.Drawing.Point(332, 320);
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.ReadOnly = true;
            this.TBDescuento.Size = new System.Drawing.Size(47, 20);
            this.TBDescuento.TabIndex = 3;
            this.TBDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBDescuento
            // 
            this.LBDescuento.AutoSize = true;
            this.LBDescuento.Location = new System.Drawing.Point(267, 323);
            this.LBDescuento.Name = "LBDescuento";
            this.LBDescuento.Size = new System.Drawing.Size(59, 13);
            this.LBDescuento.TabIndex = 10;
            this.LBDescuento.Text = "Descuento";
            // 
            // LBSubtotal
            // 
            this.LBSubtotal.AutoSize = true;
            this.LBSubtotal.Location = new System.Drawing.Point(280, 364);
            this.LBSubtotal.Name = "LBSubtotal";
            this.LBSubtotal.Size = new System.Drawing.Size(46, 13);
            this.LBSubtotal.TabIndex = 11;
            this.LBSubtotal.Text = "Subtotal";
            // 
            // TBSubtotal
            // 
            this.TBSubtotal.Location = new System.Drawing.Point(332, 357);
            this.TBSubtotal.Name = "TBSubtotal";
            this.TBSubtotal.ReadOnly = true;
            this.TBSubtotal.Size = new System.Drawing.Size(52, 20);
            this.TBSubtotal.TabIndex = 6;
            this.TBSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTNRegistrar
            // 
            this.BTNRegistrar.Enabled = false;
            this.BTNRegistrar.Location = new System.Drawing.Point(407, 330);
            this.BTNRegistrar.Name = "BTNRegistrar";
            this.BTNRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BTNRegistrar.TabIndex = 8;
            this.BTNRegistrar.Text = "Registrar";
            this.BTNRegistrar.UseVisualStyleBackColor = true;
            this.BTNRegistrar.Click += new System.EventHandler(this.BTNRegistrar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Enabled = false;
            this.BTNEliminar.Location = new System.Drawing.Point(505, 380);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(90, 23);
            this.BTNEliminar.TabIndex = 14;
            this.BTNEliminar.Text = "Eliminar Articulo";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(407, 380);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 16;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNMostrar
            // 
            this.BTNMostrar.Location = new System.Drawing.Point(601, 380);
            this.BTNMostrar.Name = "BTNMostrar";
            this.BTNMostrar.Size = new System.Drawing.Size(86, 23);
            this.BTNMostrar.TabIndex = 15;
            this.BTNMostrar.Text = "Mostrar Ventas";
            this.BTNMostrar.UseVisualStyleBackColor = true;
            this.BTNMostrar.Visible = false;
            this.BTNMostrar.Click += new System.EventHandler(this.BTNMostrar_Click);
            // 
            // LBTotal
            // 
            this.LBTotal.AutoSize = true;
            this.LBTotal.Location = new System.Drawing.Point(519, 256);
            this.LBTotal.Name = "LBTotal";
            this.LBTotal.Size = new System.Drawing.Size(65, 13);
            this.LBTotal.TabIndex = 18;
            this.LBTotal.Text = "Total Venta:";
            // 
            // TBTotal
            // 
            this.TBTotal.Location = new System.Drawing.Point(594, 253);
            this.TBTotal.Name = "TBTotal";
            this.TBTotal.ReadOnly = true;
            this.TBTotal.Size = new System.Drawing.Size(75, 20);
            this.TBTotal.TabIndex = 9;
            this.TBTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBTotal.TextChanged += new System.EventHandler(this.TBTotal_TextChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Enabled = false;
            this.BTNBuscar.Location = new System.Drawing.Point(18, 359);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(93, 23);
            this.BTNBuscar.TabIndex = 4;
            this.BTNBuscar.Text = "Buscar Articulo";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNActBusqueda
            // 
            this.BTNActBusqueda.Enabled = false;
            this.BTNActBusqueda.Location = new System.Drawing.Point(117, 359);
            this.BTNActBusqueda.Name = "BTNActBusqueda";
            this.BTNActBusqueda.Size = new System.Drawing.Size(118, 23);
            this.BTNActBusqueda.TabIndex = 5;
            this.BTNActBusqueda.Text = "Actualizar Busqueda";
            this.BTNActBusqueda.UseVisualStyleBackColor = true;
            this.BTNActBusqueda.Click += new System.EventHandler(this.BTNActBusqueda_Click);
            // 
            // BTNCalcular
            // 
            this.BTNCalcular.Enabled = false;
            this.BTNCalcular.Location = new System.Drawing.Point(407, 292);
            this.BTNCalcular.Name = "BTNCalcular";
            this.BTNCalcular.Size = new System.Drawing.Size(75, 23);
            this.BTNCalcular.TabIndex = 7;
            this.BTNCalcular.Text = "Calcular";
            this.BTNCalcular.UseVisualStyleBackColor = true;
            this.BTNCalcular.Click += new System.EventHandler(this.BTNCalcular_Click);
            // 
            // LBPago
            // 
            this.LBPago.AutoSize = true;
            this.LBPago.Location = new System.Drawing.Point(539, 283);
            this.LBPago.Name = "LBPago";
            this.LBPago.Size = new System.Drawing.Size(35, 13);
            this.LBPago.TabIndex = 35;
            this.LBPago.Text = "Pago:";
            // 
            // TBPago
            // 
            this.TBPago.Enabled = false;
            this.TBPago.Location = new System.Drawing.Point(594, 280);
            this.TBPago.Name = "TBPago";
            this.TBPago.Size = new System.Drawing.Size(75, 20);
            this.TBPago.TabIndex = 10;
            // 
            // BTNConfirmar
            // 
            this.BTNConfirmar.Enabled = false;
            this.BTNConfirmar.Location = new System.Drawing.Point(601, 334);
            this.BTNConfirmar.Name = "BTNConfirmar";
            this.BTNConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BTNConfirmar.TabIndex = 13;
            this.BTNConfirmar.Text = "Confirmar";
            this.BTNConfirmar.UseVisualStyleBackColor = true;
            this.BTNConfirmar.Click += new System.EventHandler(this.BTNConfirmar_Click);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(520, 334);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(75, 23);
            this.BTNNuevo.TabIndex = 12;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // LBCambio
            // 
            this.LBCambio.AutoSize = true;
            this.LBCambio.Location = new System.Drawing.Point(532, 311);
            this.LBCambio.Name = "LBCambio";
            this.LBCambio.Size = new System.Drawing.Size(45, 13);
            this.LBCambio.TabIndex = 41;
            this.LBCambio.Text = "Cambio:";
            // 
            // TBCambio
            // 
            this.TBCambio.Enabled = false;
            this.TBCambio.Location = new System.Drawing.Point(594, 308);
            this.TBCambio.Name = "TBCambio";
            this.TBCambio.Size = new System.Drawing.Size(75, 20);
            this.TBCambio.TabIndex = 11;
            // 
            // FRMVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 430);
            this.ControlBox = false;
            this.Controls.Add(this.TBCambio);
            this.Controls.Add(this.LBCambio);
            this.Controls.Add(this.BTNNuevo);
            this.Controls.Add(this.BTNConfirmar);
            this.Controls.Add(this.TBPago);
            this.Controls.Add(this.LBPago);
            this.Controls.Add(this.BTNCalcular);
            this.Controls.Add(this.BTNActBusqueda);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.TBTotal);
            this.Controls.Add(this.LBTotal);
            this.Controls.Add(this.BTNMostrar);
            this.Controls.Add(this.BTNSalir);
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
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.Button BTNActBusqueda;
        private System.Windows.Forms.Button BTNCalcular;
        private System.Windows.Forms.Label LBPago;
        private System.Windows.Forms.TextBox TBPago;
        private System.Windows.Forms.Button BTNConfirmar;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Label LBCambio;
        private System.Windows.Forms.TextBox TBCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}

