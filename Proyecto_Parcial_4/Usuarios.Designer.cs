
namespace Proyecto_Parcial_4
{
    partial class FMRUsuarios
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
            this.DTGVUsuario = new System.Windows.Forms.DataGridView();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBUsuario = new System.Windows.Forms.Label();
            this.txtb_usu = new System.Windows.Forms.TextBox();
            this.LBPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LBAdmin = new System.Windows.Forms.Label();
            this.CBAdmin = new System.Windows.Forms.ComboBox();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.Contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DTGVUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // DTGVUsuario
            // 
            this.DTGVUsuario.AllowUserToAddRows = false;
            this.DTGVUsuario.AllowUserToDeleteRows = false;
            this.DTGVUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGVUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Indice,
            this.Usuario,
            this.Administrador,
            this.Contraseña});
            this.DTGVUsuario.Location = new System.Drawing.Point(22, 22);
            this.DTGVUsuario.Name = "DTGVUsuario";
            this.DTGVUsuario.ReadOnly = true;
            this.DTGVUsuario.Size = new System.Drawing.Size(294, 150);
            this.DTGVUsuario.TabIndex = 0;
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Índice";
            this.Indice.Name = "Indice";
            this.Indice.ReadOnly = true;
            this.Indice.Width = 50;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Administrador
            // 
            this.Administrador.HeaderText = "Administrador";
            this.Administrador.Name = "Administrador";
            this.Administrador.ReadOnly = true;
            // 
            // LBUsuario
            // 
            this.LBUsuario.AutoSize = true;
            this.LBUsuario.Location = new System.Drawing.Point(19, 199);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(43, 13);
            this.LBUsuario.TabIndex = 1;
            this.LBUsuario.Text = "Usuario";
            // 
            // txtb_usu
            // 
            this.txtb_usu.Location = new System.Drawing.Point(104, 196);
            this.txtb_usu.Name = "txtb_usu";
            this.txtb_usu.Size = new System.Drawing.Size(100, 20);
            this.txtb_usu.TabIndex = 2;
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Location = new System.Drawing.Point(19, 229);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(61, 13);
            this.LBPassword.TabIndex = 3;
            this.LBPassword.Text = "Contraseña";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(104, 226);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 4;
            // 
            // LBAdmin
            // 
            this.LBAdmin.AutoSize = true;
            this.LBAdmin.Location = new System.Drawing.Point(19, 262);
            this.LBAdmin.Name = "LBAdmin";
            this.LBAdmin.Size = new System.Drawing.Size(70, 13);
            this.LBAdmin.TabIndex = 5;
            this.LBAdmin.Text = "Administrador";
            // 
            // CBAdmin
            // 
            this.CBAdmin.FormattingEnabled = true;
            this.CBAdmin.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CBAdmin.Location = new System.Drawing.Point(104, 259);
            this.CBAdmin.Name = "CBAdmin";
            this.CBAdmin.Size = new System.Drawing.Size(100, 21);
            this.CBAdmin.TabIndex = 6;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(241, 194);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregar.TabIndex = 7;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(241, 223);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(75, 23);
            this.BTNModificar.TabIndex = 8;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Enabled = false;
            this.BTNActualizar.Location = new System.Drawing.Point(241, 257);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(75, 23);
            this.BTNActualizar.TabIndex = 9;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(259, 302);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 20;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // Contraseña
            // 
            this.Contraseña.HeaderText = "Contraseña";
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.ReadOnly = true;
            // 
            // FMRUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 337);
            this.ControlBox = false;
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.CBAdmin);
            this.Controls.Add(this.LBAdmin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LBPassword);
            this.Controls.Add(this.txtb_usu);
            this.Controls.Add(this.LBUsuario);
            this.Controls.Add(this.DTGVUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DTGVUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTGVUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrador;
        private System.Windows.Forms.Label LBUsuario;
        private System.Windows.Forms.TextBox txtb_usu;
        private System.Windows.Forms.Label LBPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LBAdmin;
        private System.Windows.Forms.ComboBox CBAdmin;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contraseña;
    }
}