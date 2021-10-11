
namespace Proyecto_Parcial_4
{
    partial class FRMHistorial
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
            this.DTGVHistorial = new System.Windows.Forms.DataGridView();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVHistorial
            // 
            this.DTGVHistorial.AllowUserToAddRows = false;
            this.DTGVHistorial.AllowUserToDeleteRows = false;
            this.DTGVHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Articulo,
            this.Cantidad});
            this.DTGVHistorial.Location = new System.Drawing.Point(12, 12);
            this.DTGVHistorial.Name = "DTGVHistorial";
            this.DTGVHistorial.ReadOnly = true;
            this.DTGVHistorial.Size = new System.Drawing.Size(343, 306);
            this.DTGVHistorial.TabIndex = 0;
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(280, 324);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 20;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
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
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // FRMHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 359);
            this.ControlBox = false;
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.DTGVHistorial);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMHistorial";
            this.Text = "Historial";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button BTNCerrar;
    }
}