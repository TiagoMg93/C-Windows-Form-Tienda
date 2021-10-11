
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LBTitle = new System.Windows.Forms.Label();
            this.LBTitle2 = new System.Windows.Forms.Label();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.LBTitle3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBCodigo
            // 
            this.CBCodigo.AutoSize = true;
            this.CBCodigo.Location = new System.Drawing.Point(199, 45);
            this.CBCodigo.Name = "CBCodigo";
            this.CBCodigo.Size = new System.Drawing.Size(59, 17);
            this.CBCodigo.TabIndex = 0;
            this.CBCodigo.Text = "Código";
            this.CBCodigo.UseVisualStyleBackColor = true;
            // 
            // CBNombre
            // 
            this.CBNombre.AutoSize = true;
            this.CBNombre.Location = new System.Drawing.Point(200, 72);
            this.CBNombre.Name = "CBNombre";
            this.CBNombre.Size = new System.Drawing.Size(63, 17);
            this.CBNombre.TabIndex = 1;
            this.CBNombre.Text = "Nombre";
            this.CBNombre.UseVisualStyleBackColor = true;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(49, 68);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 2;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            // 
            // CBBusqueda
            // 
            this.CBBusqueda.Enabled = false;
            this.CBBusqueda.FormattingEnabled = true;
            this.CBBusqueda.Location = new System.Drawing.Point(35, 143);
            this.CBBusqueda.Name = "CBBusqueda";
            this.CBBusqueda.Size = new System.Drawing.Size(121, 21);
            this.CBBusqueda.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // LBTitle
            // 
            this.LBTitle.AutoSize = true;
            this.LBTitle.Location = new System.Drawing.Point(32, 26);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(103, 13);
            this.LBTitle.TabIndex = 5;
            this.LBTitle.Text = "Ingrese la busqueda";
            // 
            // LBTitle2
            // 
            this.LBTitle2.AutoSize = true;
            this.LBTitle2.Location = new System.Drawing.Point(197, 26);
            this.LBTitle2.Name = "LBTitle2";
            this.LBTitle2.Size = new System.Drawing.Size(61, 13);
            this.LBTitle2.TabIndex = 6;
            this.LBTitle2.Text = "Buscar por:";
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(187, 180);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 7;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.Enabled = false;
            this.BTNAceptar.Location = new System.Drawing.Point(35, 180);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(75, 23);
            this.BTNAceptar.TabIndex = 8;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = true;
            // 
            // LBTitle3
            // 
            this.LBTitle3.AutoSize = true;
            this.LBTitle3.Location = new System.Drawing.Point(46, 118);
            this.LBTitle3.Name = "LBTitle3";
            this.LBTitle3.Size = new System.Drawing.Size(110, 13);
            this.LBTitle3.TabIndex = 9;
            this.LBTitle3.Text = "Seleccione el artículo";
            // 
            // FMRBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 229);
            this.ControlBox = false;
            this.Controls.Add(this.LBTitle3);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.LBTitle2);
            this.Controls.Add(this.LBTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CBBusqueda);
            this.Controls.Add(this.BTNBuscar);
            this.Controls.Add(this.CBNombre);
            this.Controls.Add(this.CBCodigo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRBusqueda";
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBCodigo;
        private System.Windows.Forms.CheckBox CBNombre;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.ComboBox CBBusqueda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LBTitle;
        private System.Windows.Forms.Label LBTitle2;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Label LBTitle3;
    }
}