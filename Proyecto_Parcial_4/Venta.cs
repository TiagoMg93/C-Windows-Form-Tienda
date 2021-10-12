using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Parcial_4
{
    public partial class FRMVenta : Form
    {
        public FRMVenta(bool administrador)
        {
            InitializeComponent();
            
            
        }

        private void FRMVenta_Load(object sender, EventArgs e)
        {
            
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[f_prov]:Formulario provedores
            FMRProveedores f_prov = new FMRProveedores();
            f_prov.Show();
            this.Hide();
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[f_dev]:Formulario devoluciones
            FMRDevoluciones f_dev = new FMRDevoluciones();
            f_dev.Show();
            this.Hide();            
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[f_infor]:Formulario informe
            FMRInformes f_infor = new FMRInformes();
            f_infor.Show();
            this.Hide();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[f_inve]:Formulario inventario
            FMRInventarios f_inve = new FMRInventarios();
            f_inve.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[f_usu]:Formulario usuario 
            FMRUsuarios f_usu = new FMRUsuarios();
            f_usu.Show();
            this.Hide();
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[f_des]:Formulario descuento
            FMRDescuentos f_des = new FMRDescuentos();
            f_des.Show();
            this.Hide();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //[f_his]:Formulario historial
            FRMHistorial f_his = new FRMHistorial();
            f_his.Show();
            this.Hide();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            //[f_ing]:Formulario ingreso
            FMRIngreso f_ing = new FMRIngreso();
            f_ing.Show();
            this.Hide();
        }
    }
}
