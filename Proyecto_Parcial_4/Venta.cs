using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Parcial_4
{
    public partial class FRMVenta : Form
    {
        //[adm]:adminsitrador
        bool adm;//La instancio aquí para poder utilizarla en todo el formulario
        private int n = 0;//Me sirve para guardar las filas del data grid y que cuando yo seleccione algo lo pueda borrar
        int codigo;
        double totalventa = 0;
        string decision;
        public FRMVenta(bool administrador)
        {
            InitializeComponent();
         //estoy recibiendo el bool del formulario anterior(administrador) aquí porque es el unico lugar que me deja instanciar.
          adm = administrador;                        
        }

        private void FRMVenta_Load(object sender, EventArgs e)
        {
            //DGVVenta.Rows.Add();
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
            //[pre]:precio, [cant]:Cantidad
            TBPrecio.Text = "500";//LO TENGO PARA COMPROBAR QUE ME FUNCIONE

            //calculo
            double pre = int.Parse(TBPrecio.Text);
            int cant = int.Parse(TBCantidad.Text);
            double des = 5;
            double pre_cant = pre * cant;
            double des_cal = pre_cant * des / 100;//es el calculo del descuento
            double subtotal = pre_cant - des_cal;//Calculo para saber el subtotal

            totalventa = totalventa + subtotal;//acumulador del total de todas las ventas

            codigo = 123;//tiene que venirme del sql 



            n = DGVVenta.Rows.Add();//le agrega un renglon al data grid view
            DGVVenta.Rows[n].Cells[4].Value = TBCantidad.Text;
            DGVVenta.Rows[n].Cells[1].Value = CBArticulo.Text;
            DGVVenta.Rows[n].Cells[5].Value =$"{subtotal}";
            DGVVenta.Rows[n].Cells[0].Value = Convert.ToString(codigo);

            //imprime el total de la venta
            TBTotal.Text = Convert.ToString(totalventa);

            //me los pone vacios 
            TBCantidad.Text = "";
            CBArticulo.Text = "";
        }

        private void BTNEliminar_Click(object sender, EventArgs e)//elimina los renglones del datagridview
        {
            
            decision = Convert.ToString(Interaction.InputBox("Escriba el código"));
            
            for(int a=0;a<DGVVenta.Rows.Count;a++)
            {
                
                if(decision==Convert.ToString(DGVVenta.Rows[a].Cells[0].Value))
                {
                    DGVVenta.Rows.RemoveAt(a);

                }
            }

            

        }

        private void DGVVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)//recoge info del datagrid
        {
            n = e.RowIndex;//me va a guardar el numero del renglon en que estoy parado 
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            CBArticulo.ResetText();
            TBCantidad.ResetText();
            TBPrecio.ResetText();
            TBSubtotal.ResetText();
            TBDescuento.ResetText();

        }
    }
}
