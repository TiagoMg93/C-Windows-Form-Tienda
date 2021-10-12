
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
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.LBUtilidades = new System.Windows.Forms.Label();
            this.LBMenosvendido = new System.Windows.Forms.Label();
            this.LBMasvendido = new System.Windows.Forms.Label();
            this.LBTiTle = new System.Windows.Forms.Label();
            this.LBGanancias = new System.Windows.Forms.Label();
            this.TBMasvendido = new System.Windows.Forms.TextBox();
            this.TBMenosvendido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(238, 180);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 20;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            // 
            // LBUtilidades
            // 
            this.LBUtilidades.AutoSize = true;
            this.LBUtilidades.Location = new System.Drawing.Point(80, 39);
            this.LBUtilidades.Name = "LBUtilidades";
            this.LBUtilidades.Size = new System.Drawing.Size(53, 13);
            this.LBUtilidades.TabIndex = 21;
            this.LBUtilidades.Text = "Utilidades";
            // 
            // LBMenosvendido
            // 
            this.LBMenosvendido.AutoSize = true;
            this.LBMenosvendido.Location = new System.Drawing.Point(31, 126);
            this.LBMenosvendido.Name = "LBMenosvendido";
            this.LBMenosvendido.Size = new System.Drawing.Size(119, 13);
            this.LBMenosvendido.TabIndex = 22;
            this.LBMenosvendido.Text = "Artículo menos vendido";
            // 
            // LBMasvendido
            // 
            this.LBMasvendido.AutoSize = true;
            this.LBMasvendido.Location = new System.Drawing.Point(43, 83);
            this.LBMasvendido.Name = "LBMasvendido";
            this.LBMasvendido.Size = new System.Drawing.Size(107, 13);
            this.LBMasvendido.TabIndex = 23;
            this.LBMasvendido.Text = "Artículo más vendido";
            // 
            // LBTiTle
            // 
            this.LBTiTle.AutoSize = true;
            this.LBTiTle.Location = new System.Drawing.Point(194, 39);
            this.LBTiTle.Name = "LBTiTle";
            this.LBTiTle.Size = new System.Drawing.Size(13, 13);
            this.LBTiTle.TabIndex = 24;
            this.LBTiTle.Text = "$";
            // 
            // LBGanancias
            // 
            this.LBGanancias.AutoSize = true;
            this.LBGanancias.Location = new System.Drawing.Point(235, 39);
            this.LBGanancias.Name = "LBGanancias";
            this.LBGanancias.Size = new System.Drawing.Size(13, 13);
            this.LBGanancias.TabIndex = 25;
            this.LBGanancias.Text = "0";
            // 
            // TBMasvendido
            // 
            this.TBMasvendido.Location = new System.Drawing.Point(178, 80);
            this.TBMasvendido.Name = "TBMasvendido";
            this.TBMasvendido.ReadOnly = true;
            this.TBMasvendido.Size = new System.Drawing.Size(100, 20);
            this.TBMasvendido.TabIndex = 26;
            // 
            // TBMenosvendido
            // 
            this.TBMenosvendido.Location = new System.Drawing.Point(178, 123);
            this.TBMenosvendido.Name = "TBMenosvendido";
            this.TBMenosvendido.ReadOnly = true;
            this.TBMenosvendido.Size = new System.Drawing.Size(100, 20);
            this.TBMenosvendido.TabIndex = 27;
            // 
            // FMRInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 218);
            this.ControlBox = false;
            this.Controls.Add(this.TBMenosvendido);
            this.Controls.Add(this.TBMasvendido);
            this.Controls.Add(this.LBGanancias);
            this.Controls.Add(this.LBTiTle);
            this.Controls.Add(this.LBMasvendido);
            this.Controls.Add(this.LBMenosvendido);
            this.Controls.Add(this.LBUtilidades);
            this.Controls.Add(this.BTNCerrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRInformes";
            this.Text = "Informes";
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
        private System.Windows.Forms.TextBox TBMasvendido;
        private System.Windows.Forms.TextBox TBMenosvendido;
    }
}