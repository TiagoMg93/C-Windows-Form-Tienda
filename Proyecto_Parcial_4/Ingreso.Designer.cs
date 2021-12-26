
namespace Proyecto_Parcial_4
{
    partial class FMRIngreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRIngreso));
            this.TBUser = new System.Windows.Forms.TextBox();
            this.LBUser = new System.Windows.Forms.Label();
            this.LBPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTNEntrar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.CBServer = new System.Windows.Forms.ComboBox();
            this.LBServidor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(141, 119);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(100, 20);
            this.TBUser.TabIndex = 1;
            this.TBUser.TextChanged += new System.EventHandler(this.TBUser_TextChanged);
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.Location = new System.Drawing.Point(44, 122);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(43, 13);
            this.LBUser.TabIndex = 1;
            this.LBUser.Text = "Usuario";
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Location = new System.Drawing.Point(35, 157);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(61, 13);
            this.LBPassword.TabIndex = 2;
            this.LBPassword.Text = "Contraseña";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(141, 154);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 2;
            this.TBPassword.TextChanged += new System.EventHandler(this.TBPassword_TextChanged);
            // 
            // BTNEntrar
            // 
            this.BTNEntrar.Location = new System.Drawing.Point(12, 201);
            this.BTNEntrar.Name = "BTNEntrar";
            this.BTNEntrar.Size = new System.Drawing.Size(75, 23);
            this.BTNEntrar.TabIndex = 3;
            this.BTNEntrar.Text = "Entrar";
            this.BTNEntrar.UseVisualStyleBackColor = true;
            this.BTNEntrar.Click += new System.EventHandler(this.BTNEntrar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(220, 201);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 4;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // CBServer
            // 
            this.CBServer.FormattingEnabled = true;
            this.CBServer.Items.AddRange(new object[] {
            "DESKTOP-108L2NP"});
            this.CBServer.Location = new System.Drawing.Point(141, 80);
            this.CBServer.Name = "CBServer";
            this.CBServer.Size = new System.Drawing.Size(121, 21);
            this.CBServer.TabIndex = 0;
            // 
            // LBServidor
            // 
            this.LBServidor.AutoSize = true;
            this.LBServidor.Location = new System.Drawing.Point(19, 83);
            this.LBServidor.Name = "LBServidor";
            this.LBServidor.Size = new System.Drawing.Size(103, 13);
            this.LBServidor.TabIndex = 8;
            this.LBServidor.Text = "Nombre del Servidor";
            // 
            // FMRIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 236);
            this.ControlBox = false;
            this.Controls.Add(this.LBServidor);
            this.Controls.Add(this.CBServer);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNEntrar);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LBPassword);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.TBUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.FMRIngreso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.Label LBUser;
        private System.Windows.Forms.Label LBPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTNEntrar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.ComboBox CBServer;
        private System.Windows.Forms.Label LBServidor;
    }
}