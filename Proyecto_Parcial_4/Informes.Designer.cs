
namespace Proyecto_Parcial_4
{
    partial class FMRInformes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRInformes));
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.LBUtilidades = new System.Windows.Forms.Label();
            this.LBMenosvendido = new System.Windows.Forms.Label();
            this.LBMasvendido = new System.Windows.Forms.Label();
            this.LBTiTle = new System.Windows.Forms.Label();
            this.LBGanancias = new System.Windows.Forms.Label();
            this.Title3 = new System.Windows.Forms.Label();
            this.Title2 = new System.Windows.Forms.Label();
            this.LBVentas = new System.Windows.Forms.Label();
            this.LBArtMas = new System.Windows.Forms.Label();
            this.LBArtMen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(211, 230);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 0;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // LBUtilidades
            // 
            this.LBUtilidades.AutoSize = true;
            this.LBUtilidades.Location = new System.Drawing.Point(35, 108);
            this.LBUtilidades.Name = "LBUtilidades";
            this.LBUtilidades.Size = new System.Drawing.Size(53, 13);
            this.LBUtilidades.TabIndex = 21;
            this.LBUtilidades.Text = "Utilidades";
            // 
            // LBMenosvendido
            // 
            this.LBMenosvendido.AutoSize = true;
            this.LBMenosvendido.Location = new System.Drawing.Point(13, 190);
            this.LBMenosvendido.Name = "LBMenosvendido";
            this.LBMenosvendido.Size = new System.Drawing.Size(119, 13);
            this.LBMenosvendido.TabIndex = 22;
            this.LBMenosvendido.Text = "Artículo menos vendido";
            // 
            // LBMasvendido
            // 
            this.LBMasvendido.AutoSize = true;
            this.LBMasvendido.Location = new System.Drawing.Point(13, 150);
            this.LBMasvendido.Name = "LBMasvendido";
            this.LBMasvendido.Size = new System.Drawing.Size(107, 13);
            this.LBMasvendido.TabIndex = 23;
            this.LBMasvendido.Text = "Artículo más vendido";
            // 
            // LBTiTle
            // 
            this.LBTiTle.AutoSize = true;
            this.LBTiTle.Location = new System.Drawing.Point(159, 108);
            this.LBTiTle.Name = "LBTiTle";
            this.LBTiTle.Size = new System.Drawing.Size(13, 13);
            this.LBTiTle.TabIndex = 24;
            this.LBTiTle.Text = "$";
            // 
            // LBGanancias
            // 
            this.LBGanancias.AutoSize = true;
            this.LBGanancias.Location = new System.Drawing.Point(195, 108);
            this.LBGanancias.Name = "LBGanancias";
            this.LBGanancias.Size = new System.Drawing.Size(13, 13);
            this.LBGanancias.TabIndex = 25;
            this.LBGanancias.Text = "0";
            // 
            // Title3
            // 
            this.Title3.AutoSize = true;
            this.Title3.Location = new System.Drawing.Point(35, 71);
            this.Title3.Name = "Title3";
            this.Title3.Size = new System.Drawing.Size(74, 13);
            this.Title3.TabIndex = 28;
            this.Title3.Text = "Ventas totales";
            // 
            // Title2
            // 
            this.Title2.AutoSize = true;
            this.Title2.Location = new System.Drawing.Point(159, 71);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(13, 13);
            this.Title2.TabIndex = 29;
            this.Title2.Text = "$";
            // 
            // LBVentas
            // 
            this.LBVentas.AutoSize = true;
            this.LBVentas.Location = new System.Drawing.Point(195, 71);
            this.LBVentas.Name = "LBVentas";
            this.LBVentas.Size = new System.Drawing.Size(13, 13);
            this.LBVentas.TabIndex = 30;
            this.LBVentas.Text = "0";
            // 
            // LBArtMas
            // 
            this.LBArtMas.AutoSize = true;
            this.LBArtMas.Location = new System.Drawing.Point(173, 150);
            this.LBArtMas.Name = "LBArtMas";
            this.LBArtMas.Size = new System.Drawing.Size(47, 13);
            this.LBArtMas.TabIndex = 31;
            this.LBArtMas.Text = "Ninguno";
            // 
            // LBArtMen
            // 
            this.LBArtMen.AutoSize = true;
            this.LBArtMen.Location = new System.Drawing.Point(173, 190);
            this.LBArtMen.Name = "LBArtMen";
            this.LBArtMen.Size = new System.Drawing.Size(47, 13);
            this.LBArtMen.TabIndex = 32;
            this.LBArtMen.Text = "Ninguno";
            // 
            // FMRInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 265);
            this.ControlBox = false;
            this.Controls.Add(this.LBArtMen);
            this.Controls.Add(this.LBArtMas);
            this.Controls.Add(this.LBVentas);
            this.Controls.Add(this.Title2);
            this.Controls.Add(this.Title3);
            this.Controls.Add(this.LBGanancias);
            this.Controls.Add(this.LBTiTle);
            this.Controls.Add(this.LBMasvendido);
            this.Controls.Add(this.LBMenosvendido);
            this.Controls.Add(this.LBUtilidades);
            this.Controls.Add(this.BTNCerrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.FMRInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Label LBUtilidades;
        private System.Windows.Forms.Label LBMenosvendido;
        private System.Windows.Forms.Label LBMasvendido;
        private System.Windows.Forms.Label LBTiTle;
        private System.Windows.Forms.Label LBGanancias;
        private System.Windows.Forms.Label Title3;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label LBVentas;
        private System.Windows.Forms.Label LBArtMas;
        private System.Windows.Forms.Label LBArtMen;
    }
}