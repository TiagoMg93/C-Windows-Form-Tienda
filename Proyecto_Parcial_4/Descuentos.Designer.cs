
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
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBTitle = new System.Windows.Forms.Label();
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.LBTitle2 = new System.Windows.Forms.Label();
            this.TBDescuento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDescuento)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(297, 381);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 21;
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
            this.Descuento});
            this.DTGVDescuento.Location = new System.Drawing.Point(22, 44);
            this.DTGVDescuento.Name = "DTGVDescuento";
            this.DTGVDescuento.Size = new System.Drawing.Size(344, 150);
            this.DTGVDescuento.TabIndex = 22;
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
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Location = new System.Drawing.Point(130, 18);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(123, 13);
            this.LBTitle.TabIndex = 23;
            this.LBTitle.Text = "Artículos con descuento";
            // 
            // CBArticulo
            // 
            this.CBArticulo.Enabled = false;
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(59, 219);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(174, 21);
            this.CBArticulo.TabIndex = 24;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Enabled = false;
            this.BTNBuscar.Location = new System.Drawing.Point(250, 219);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(89, 21);
            this.BTNBuscar.TabIndex = 25;
            this.BTNBuscar.Text = "Buscar Artículo";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(250, 261);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregar.TabIndex = 26;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(250, 300);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(75, 23);
            this.BTNModificar.TabIndex = 27;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Enabled = false;
            this.BTNActualizar.Location = new System.Drawing.Point(250, 338);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(75, 23);
            this.BTNActualizar.TabIndex = 28;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            // 
            // LBTitle2
            // 
            this.LBTitle2.AutoSize = true;
            this.LBTitle2.Location = new System.Drawing.Point(56, 282);
            this.LBTitle2.Name = "LBTitle2";
            this.LBTitle2.Size = new System.Drawing.Size(59, 13);
            this.LBTitle2.TabIndex = 30;
            this.LBTitle2.Text = "Descuento";
            // 
            // TBDescuento
            // 
            this.TBDescuento.Enabled = false;
            this.TBDescuento.Location = new System.Drawing.Point(133, 279);
            this.TBDescuento.Name = "TBDescuento";
            this.TBDescuento.Size = new System.Drawing.Size(100, 20);
            this.TBDescuento.TabIndex = 31;
            // 
            // FMRDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 415);
            this.ControlBox = false;
            this.Controls.Add(this.TBDescuento);
            this.Controls.Add(this.LBTitle2);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.CBArticulo);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.DTGVDescuento);
            this.Controls.Add(this.BTNCerrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRDescuentos";
            this.Text = "Descuentos";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVDescuento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.DataGridView DTGVDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Label LBTitle2;
        private System.Windows.Forms.TextBox TBDescuento;
    }
}