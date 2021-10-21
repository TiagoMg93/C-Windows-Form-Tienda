
namespace Proyecto_Parcial_4
{
    partial class FMRBusqueda
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
            this.CBCodigo = new System.Windows.Forms.CheckBox();
            this.CBNombre = new System.Windows.Forms.CheckBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.CBBusqueda = new System.Windows.Forms.ComboBox();
            this.TBBusqueda = new System.Windows.Forms.TextBox();
            this.LBTitle = new System.Windows.Forms.Label();
            this.LBTitle2 = new System.Windows.Forms.Label();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.LBTitle3 = new System.Windows.Forms.Label();
            this.CBMarca = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CBCodigo
            // 
            this.CBCodigo.AutoSize = true;
            this.CBCodigo.Location = new System.Drawing.Point(186, 101);
            this.CBCodigo.Name = "CBCodigo";
            this.CBCodigo.Size = new System.Drawing.Size(59, 17);
            this.CBCodigo.TabIndex = 0;
            this.CBCodigo.Text = "Código";
            this.CBCodigo.UseVisualStyleBackColor = true;
            this.CBCodigo.CheckedChanged += new System.EventHandler(this.CBCodigo_CheckedChanged);
            // 
            // CBNombre
            // 
            this.CBNombre.AutoSize = true;
            this.CBNombre.Location = new System.Drawing.Point(186, 124);
            this.CBNombre.Name = "CBNombre";
            this.CBNombre.Size = new System.Drawing.Size(63, 17);
            this.CBNombre.TabIndex = 1;
            this.CBNombre.Text = "Nombre";
            this.CBNombre.UseVisualStyleBackColor = true;
            this.CBNombre.CheckedChanged += new System.EventHandler(this.CBNombre_CheckedChanged);
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(36, 124);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 2;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.Enabled = false;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(22, 189);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(166, 21);
            this.CBBusqueda.TabIndex = 3;
            this.CBBusqueda.SelectedIndexChanged += new System.EventHandler(this.CBBusqueda_SelectedIndexChanged);
            // 
            // TBBusqueda
            // 
            this.TBBusqueda.Enabled = false;
            this.TBBusqueda.Location = new System.Drawing.Point(22, 98);
            this.TBBusqueda.Name = "TBBusqueda";
            this.TBBusqueda.Size = new System.Drawing.Size(100, 20);
            this.TBBusqueda.TabIndex = 4;
            this.TBBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Location = new System.Drawing.Point(19, 82);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(103, 13);
            this.LBTitle.TabIndex = 5;
            this.LBTitle.Text = "Ingrese la busqueda";
            // 
            // LBTitle2
            // 
            this.LBTitle2.AutoSize = true;
            this.LBTitle2.Location = new System.Drawing.Point(184, 82);
            this.LBTitle2.Name = "LBTitle2";
            this.LBTitle2.Size = new System.Drawing.Size(61, 13);
            this.LBTitle2.TabIndex = 6;
            this.LBTitle2.Text = "Buscar por:";
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(174, 236);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 7;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.Enabled = false;
            this.BTNAceptar.Location = new System.Drawing.Point(22, 236);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTNAceptar.TabIndex = 8;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // LBTitle3
            // 
            this.LBTitle3.AutoSize = true;
            this.LBTitle3.Location = new System.Drawing.Point(52, 173);
            this.LBTitle3.Name = "LBTitle3";
            this.LBTitle3.Size = new System.Drawing.Size(110, 13);
            this.LBTitle3.TabIndex = 9;
            this.LBTitle3.Text = "Seleccione el artículo";
            // 
            // CBMarca
            // 
            this.CBMarca.AutoSize = true;
            this.CBMarca.Location = new System.Drawing.Point(186, 147);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(56, 17);
            this.CBMarca.TabIndex = 10;
            this.CBMarca.Text = "Marca";
            this.CBMarca.UseVisualStyleBackColor = true;
            this.CBMarca.CheckedChanged += new System.EventHandler(this.CBMarca_CheckedChanged);
            // 
            // FMRBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 262);
            this.ControlBox = false;
            this.Controls.Add(this.CBMarca);
            this.Controls.Add(this.LBTitle3);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.LBTitle2);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.TBBusqueda);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.CBNombre);
            this.Controls.Add(this.CBCodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRBusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.FMRBusqueda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBCodigo;
        private System.Windows.Forms.CheckBox CBNombre;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox TBBusqueda;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.Label LBTitle2;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Label LBTitle3;
        private System.Windows.Forms.CheckBox CBMarca;
    }
}