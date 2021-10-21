
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
            this.TBUser = new System.Windows.Forms.TextBox();
            this.LBUser = new System.Windows.Forms.Label();
            this.LBPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTNEntrar = new System.Windows.Forms.Button();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(96, 74);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(100, 20);
            this.TBUser.TabIndex = 0;
            this.TBUser.TextChanged += new System.EventHandler(this.TBUser_TextChanged);
            // 
            // LBUser
            // 
            this.LBUser.AutoSize = true;
            this.LBUser.Location = new System.Drawing.Point(18, 77);
            this.LBUser.Name = "LBUser";
            this.LBUser.Size = new System.Drawing.Size(43, 13);
            this.LBUser.TabIndex = 1;
            this.LBUser.Text = "Usuario";
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Location = new System.Drawing.Point(4, 111);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(61, 13);
            this.LBPassword.TabIndex = 2;
            this.LBPassword.Text = "Contraseña";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(96, 108);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 3;
            this.TBPassword.TextChanged += new System.EventHandler(this.TBPassword_TextChanged);
            // 
            // BTNEntrar
            // 
            this.BTNEntrar.Location = new System.Drawing.Point(134, 154);
            this.BTNEntrar.Name = "BTNEntrar";
            this.BTNEntrar.Size = new System.Drawing.Size(75, 23);
            this.BTNEntrar.TabIndex = 4;
            this.BTNEntrar.Text = "Entrar";
            this.BTNEntrar.UseVisualStyleBackColor = true;
            this.BTNEntrar.Click += new System.EventHandler(this.BTNEntrar_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(21, 154);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 5;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // FMRIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 181);
            this.ControlBox = false;
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.BTNEntrar);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LBPassword);
            this.Controls.Add(this.LBUser);
            this.Controls.Add(this.TBUser);
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
    }
}