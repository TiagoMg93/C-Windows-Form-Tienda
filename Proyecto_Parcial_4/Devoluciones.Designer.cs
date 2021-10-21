
namespace Proyecto_Parcial_4
{
    partial class FMRDevoluciones
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
            this.CBArticulo = new System.Windows.Forms.ComboBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.LBUnidades = new System.Windows.Forms.Label();
            this.TBUnidades = new System.Windows.Forms.TextBox();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.LBTitle = new System.Windows.Forms.Label();
            this.CBEliminar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.LBTitle2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.BTNActBusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBArticulo
            // 
            this.CBArticulo.FormattingEnabled = true;
            this.CBArticulo.Location = new System.Drawing.Point(5, 86);
            this.CBArticulo.Name = "CBArticulo";
            this.CBArticulo.Size = new System.Drawing.Size(174, 21);
            this.CBArticulo.TabIndex = 5;
            this.CBArticulo.SelectedIndexChanged += new System.EventHandler(this.CBArticulo_SelectedIndexChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(195, 67);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(89, 21);
            this.BTNBuscar.TabIndex = 6;
            this.BTNBuscar.Text = "Buscar Artículo";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // LBUnidades
            // 
            this.LBUnidades.AutoSize = true;
            this.LBUnidades.Location = new System.Drawing.Point(43, 126);
            this.LBUnidades.Name = "LBUnidades";
            this.LBUnidades.Size = new System.Drawing.Size(49, 13);
            this.LBUnidades.TabIndex = 9;
            this.LBUnidades.Text = "Cantidad";
            // 
            // TBUnidades
            // 
            this.TBUnidades.Enabled = false;
            this.TBUnidades.Location = new System.Drawing.Point(111, 123);
            this.TBUnidades.Name = "TBUnidades";
            this.TBUnidades.Size = new System.Drawing.Size(100, 20);
            this.TBUnidades.TabIndex = 10;
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Enabled = false;
            this.BTNActualizar.Location = new System.Drawing.Point(111, 158);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(75, 23);
            this.BTNActualizar.TabIndex = 11;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Location = new System.Drawing.Point(4, 70);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(161, 13);
            this.LBTitle.TabIndex = 12;
            this.LBTitle.Text = "Seleccione el articulo a devolver";
            // 
            // CBEliminar
            // 
            this.CBEliminar.FormattingEnabled = true;
            this.CBEliminar.Location = new System.Drawing.Point(46, 280);
            this.CBEliminar.Name = "CBEliminar";
            this.CBEliminar.Size = new System.Drawing.Size(174, 21);
            this.CBEliminar.TabIndex = 13;
            this.CBEliminar.SelectedIndexChanged += new System.EventHandler(this.CBEliminar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Seleccione el artículo a eliminar";
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Enabled = false;
            this.BTNEliminar.Location = new System.Drawing.Point(90, 307);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 16;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // LBTitle2
            // 
            this.LBTitle2.AutoSize = true;
            this.LBTitle2.Location = new System.Drawing.Point(8, 210);
            this.LBTitle2.Name = "LBTitle2";
            this.LBTitle2.Size = new System.Drawing.Size(267, 13);
            this.LBTitle2.TabIndex = 17;
            this.LBTitle2.Text = "Solo se puede eliminar articulos sin unidades existentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "por lo tanto, primero se deben devolver las unidades existentes";
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(225, 388);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 19;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // BTNActBusqueda
            // 
            this.BTNActBusqueda.Enabled = false;
            this.BTNActBusqueda.Location = new System.Drawing.Point(185, 94);
            this.BTNActBusqueda.Name = "BTNActBusqueda";
            this.BTNActBusqueda.Size = new System.Drawing.Size(118, 23);
            this.BTNActBusqueda.TabIndex = 34;
            this.BTNActBusqueda.Text = "Actualizar Busqueda";
            this.BTNActBusqueda.UseVisualStyleBackColor = true;
            this.BTNActBusqueda.Click += new System.EventHandler(this.button1_Click);
            // 
            // FMRDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 417);
            this.ControlBox = false;
            this.Controls.Add(this.BTNActBusqueda);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBTitle2);
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBEliminar);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.TBUnidades);
            this.Controls.Add(this.LBUnidades);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.CBArticulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.FMRDevoluciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBArticulo;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Label LBUnidades;
        private System.Windows.Forms.TextBox TBUnidades;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.ComboBox CBEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Label LBTitle2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Button BTNActBusqueda;
    }
}