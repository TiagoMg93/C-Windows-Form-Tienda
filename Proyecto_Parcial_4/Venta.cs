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
        //[adm]:adminsitrador
        bool adm;//La instancio aquí para poder utilizarla en todo el formulario
        private int n = 0;//Me sirve para guardar las filas del data grid y que cuando yo seleccione algo lo pueda borrar
        public FRMVenta(bool administrador)
        {
            InitializeComponent();
         //estoy recibiendo el bool del formulario anterior(administrador) aquí porque es el unico lugar que me deja instanciar.
          adm = administrador;                        
        }

        private void FRMVenta_Load(object sender, EventArgs e)
        {
            //hago una condición if para saber si es administrador para habilitar el menustrip 
           if(adm==true)
            {
                menuStrip1.Enabled = true;
                BTNEliminar.Visible = true;
                BTNMostrar.Visible = true;

            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_prov]:Formulario provedores
            FMRProveedores f_prov = new FMRProveedores();
            f_prov.Show();            
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_dev]:Formulario devoluciones
            FMRDevoluciones f_dev = new FMRDevoluciones();
            f_dev.Show();                     
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_infor]:Formulario informe
            FMRInformes f_infor = new FMRInformes();
            f_infor.Show();            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_inve]:Formulario inventario
            FMRInventarios f_inve = new FMRInventarios();
            f_inve.Show();            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_usu]:Formulario usuario 
            FMRUsuarios f_usu = new FMRUsuarios();
            f_usu.Show();            
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_des]:Formulario descuento
            FMRDescuentos f_des = new FMRDescuentos();
            f_des.Show();            
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_his]:Formulario historial
            FRMHistorial f_his = new FRMHistorial();
            f_his.Show();           
        }

        private void BTNSalir_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_ing]:Formulario ingreso
            FMRIngreso f_ing = new FMRIngreso();
            f_ing.Show();
            this.Hide();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)//Lo que hace es que me abra el formulario
        {
            //[f_bus]:Formulario busquedad
            FMRBusqueda f_bus = new FMRBusqueda();
            f_bus.Show();
            
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            n = DGVVenta.Rows.Add();//le agrega un renglon al data grid view
            DGVVenta.Rows[n].Cells[4].Value = TBCantidad.Text;
            DGVVenta.Rows[n].Cells[1].Value = CBArticulo.Text;


            TBCantidad.Text = "";
            CBArticulo.Text = "";
        }

        private void BTNEliminar_Click(object sender, EventArgs e)//elimina los renglones del datagridview
        {
            if(n!=-1)//para que no me borre la columna donde van los tipos de datos 
            {
                DGVVenta.Rows.RemoveAt(n);//me elimina n
            }
        }

        private void DGVVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)//recoge info del datagrid
        {
            n = e.RowIndex;//me va a guardar el numero del renglon en que estoy parado 
        }
    }
}
