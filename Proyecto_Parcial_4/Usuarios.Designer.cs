
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
            this.TBUser = new System.Windows.Forms.TextBox();
            this.LBPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.LBAdmin = new System.Windows.Forms.Label();
            this.CBAdmin = new System.Windows.Forms.ComboBox();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNCerrar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
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
            this.Administrador});
            this.DTGVUsuario.Location = new System.Drawing.Point(12, 73);
            this.DTGVUsuario.Name = "DTGVUsuario";
            this.DTGVUsuario.ReadOnly = true;
            this.DTGVUsuario.Size = new System.Drawing.Size(294, 150);
            this.DTGVUsuario.TabIndex = 0;
            this.DTGVUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGVUsuario_CellContentClick);
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
            this.LBUsuario.Location = new System.Drawing.Point(9, 243);
            this.LBUsuario.Name = "LBUsuario";
            this.LBUsuario.Size = new System.Drawing.Size(43, 13);
            this.LBUsuario.TabIndex = 1;
            this.LBUsuario.Text = "Usuario";
            // 
            // TBUser
            // 
            this.TBUser.Location = new System.Drawing.Point(94, 240);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(100, 20);
            this.TBUser.TabIndex = 0;
            // 
            // LBPassword
            // 
            this.LBPassword.AutoSize = true;
            this.LBPassword.Location = new System.Drawing.Point(9, 273);
            this.LBPassword.Name = "LBPassword";
            this.LBPassword.Size = new System.Drawing.Size(61, 13);
            this.LBPassword.TabIndex = 3;
            this.LBPassword.Text = "Contraseña";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(94, 270);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 1;
            // 
            // LBAdmin
            // 
            this.LBAdmin.AutoSize = true;
            this.LBAdmin.Location = new System.Drawing.Point(9, 306);
            this.LBAdmin.Name = "LBAdmin";
            this.LBAdmin.Size = new System.Drawing.Size(70, 13);
            this.LBAdmin.TabIndex = 5;
            this.LBAdmin.Text = "Administrador";
            // 
            // CBAdmin
            // 
            this.CBAdmin.FormattingEnabled = true;
            this.CBAdmin.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CBAdmin.Location = new System.Drawing.Point(94, 303);
            this.CBAdmin.Name = "CBAdmin";
            this.CBAdmin.Size = new System.Drawing.Size(100, 21);
            this.CBAdmin.TabIndex = 2;
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(231, 238);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(75, 23);
            this.BTNAgregar.TabIndex = 3;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // BTNModificar
            // 
            this.BTNModificar.Location = new System.Drawing.Point(231, 267);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(75, 23);
            this.BTNModificar.TabIndex = 4;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = true;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Enabled = false;
            this.BTNActualizar.Location = new System.Drawing.Point(231, 301);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(75, 23);
            this.BTNActualizar.TabIndex = 5;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // BTNCerrar
            // 
            this.BTNCerrar.Location = new System.Drawing.Point(232, 349);
            this.BTNCerrar.Name = "BTNCerrar";
            this.BTNCerrar.Size = new System.Drawing.Size(75, 23);
            this.BTNCerrar.TabIndex = 7;
            this.BTNCerrar.Text = "Cerrar";
            this.BTNCerrar.UseVisualStyleBackColor = true;
            this.BTNCerrar.Click += new System.EventHandler(this.BTNCerrar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Enabled = false;
            this.BTNEliminar.Location = new System.Drawing.Point(104, 330);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 6;
            this.BTNEliminar.Text = "Eliminar Usuario";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // FMRUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 384);
            this.ControlBox = false;
            this.Controls.Add(this.BTNEliminar);
            this.Controls.Add(this.BTNCerrar);
            this.Controls.Add(this.BTNActualizar);
            this.Controls.Add(this.BTNModificar);
            this.Controls.Add(this.BTNAgregar);
            this.Controls.Add(this.CBAdmin);
            this.Controls.Add(this.LBAdmin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LBPassword);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.LBUsuario);
            this.Controls.Add(this.DTGVUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMRUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FMRUsuarios_Load);
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
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.Label LBPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label LBAdmin;
        private System.Windows.Forms.ComboBox CBAdmin;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.Button BTNModificar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNCerrar;
        private System.Windows.Forms.Button BTNEliminar;
    }
}