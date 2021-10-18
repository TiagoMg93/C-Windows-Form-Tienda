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
        /*Se ponen las variables en [public partial class] para que puedan ser utilizadas en todo el formulario*/
        bool adm;
        private int n = 0;
        int codigo;
        double totalventa = 0;
        string decision;
        public FRMVenta(bool administrador)
        {
            InitializeComponent();
           /*inicio la variable [adm] aquí porque es el único lugar que puedo instanciar la variable [administrador] que me 
            llega del formulario [ingreso]*/
          adm = administrador;                        
        }

        private void FRMVenta_Load(object sender, EventArgs e)
        {
            /*hago una condición if para saber si es administrador para habilitar los elementos que estan desactivados */
           if(adm==true)
            {
                menuStrip1.Enabled = true;
                BTNEliminar.Visible = true;
                BTNMostrar.Visible = true;

            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            /*[f_prov]:Formulario provedores
             me abre el formulario provedores*/

            FMRProveedores f_prov = new FMRProveedores();
            f_prov.Show();            
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            /*[f_dev]:Formulario devoluciones
             me abre el formulario devoluciones*/
            FMRDevoluciones f_dev = new FMRDevoluciones();
            f_dev.Show();                     
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            /*[f_infor]:Formulario informe
             me abre el formulario informes*/
            FMRInformes f_infor = new FMRInformes();
            f_infor.Show();            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            /*[f_inve]:Formulario inventario
             me abre el formulario inventario*/
            FMRInventarios f_inve = new FMRInventarios();
            f_inve.Show();            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*[f_usu]:Formulario usuarios
             me abre el formulario usuarios*/
            FMRUsuarios f_usu = new FMRUsuarios();
            f_usu.Show();            
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*[f_des]:Formulario descuento
             me abre el formulario descuento*/
            FMRDescuentos f_des = new FMRDescuentos();
            f_des.Show();            
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*[f_his]:Formulario historial
             me abre el formulario historial*/
            FRMHistorial f_his = new FRMHistorial();
            f_his.Show();           
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            /*[f_ing]:Formulario ingreso
             Me abre el formulario ingreso y el formulario ventas me la va a esconder*/
            FMRIngreso f_ing = new FMRIngreso();
            f_ing.Show();
            this.Hide();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            /*[f_bus]:Formulario busquedad
             me abre el formulario busqueda*/
            FMRBusqueda f_bus = new FMRBusqueda();
            f_bus.Show();
            
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            //[pre]:precio, [cant]:Cantidad
           //viene del sql //TBPrecio.Text = "500";//LO TENGO PARA COMPROBAR QUE ME FUNCIONE

            //calculo
            double pre = int.Parse(TBPrecio.Text);
            int cant = int.Parse(TBCantidad.Text);
            double des = 5;
            double pre_cant = pre * cant;
            double des_cal = pre_cant * des / 100;//es el proceso del descuento
            double subtotal = pre_cant - des_cal;//proceso para saber el subtotal

            totalventa = totalventa + subtotal;//acumulador del total de todas las ventas

            //VIENE DEL SQL//codigo = 123;//LO TENGO PARA COMPROBAR QUE ME FUNCIONE


            /*Le agrega un renglon al data grid view*/
            n = DGVVenta.Rows.Add();

            /*Me guarda los datos al data grid view*/
            DGVVenta.Rows[n].Cells[4].Value = TBCantidad.Text;
            DGVVenta.Rows[n].Cells[1].Value = CBArticulo.Text;
            DGVVenta.Rows[n].Cells[5].Value =$"{subtotal}";
            //VIENE DEL SQL//DGVVenta.Rows[n].Cells[0].Value = Convert.ToString(codigo);

            /*imprime el total de la venta en el text box que esta desactivado*/
            TBTotal.Text = Convert.ToString(totalventa);

            /*me limpia los datos que copiamos en el textbox y el combo box para que no tenga que limpiarlos manualmente*/
            TBCantidad.Text = "";
            CBArticulo.Text = "";
        }

        private void BTNEliminar_Click(object sender, EventArgs e)//elimina los renglones del datagridview
        {
            //SE NECESITA SQL, porque se necesita del código.
            /*Le sale una ventana al usuario para que escriba el codigo del producto que desea eliminar y lo guarda en la 
             variable [desicion]*/
            decision = Convert.ToString(Interaction.InputBox("Escriba el código"));


            /*Redcorre todo los renglones que contiene el data grid */
            for(int fila=0;fila<DGVVenta.Rows.Count;fila++)
            {
                /*Compara la variable desicion y la columna 0*/
                if(decision==Convert.ToString(DGVVenta.Rows[fila].Cells[0].Value))
                {
                    /*[conv_sub]:convertir subtotal a string, [r_sub]:la variable que va a restar al total de venta
                     me guarda el subtotal de un producto en la variable [conv_sub], para después convertirla en entera
                    y guardarmela en [r_sub]*/
                    string conv_sub =Convert.ToString(DGVVenta.Rows[fila].Cells[5].Value);
                    int r_sub = int.Parse(conv_sub);
                    /*se le va a restar al [total de venta] lo qu tenga el subtotal del producto que se va a borrar y me va
                     actualizar el resultado del total de venta del textbox*/
                    totalventa = totalventa - r_sub;                    
                    TBTotal.Text = Convert.ToString(totalventa);
                    /*y por último me elimina la fila*/
                    DGVVenta.Rows.RemoveAt(fila);

                }
            }

            

        }


        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            /*Me limpia todos los bombo box y text box*/
            CBArticulo.ResetText();
            TBCantidad.ResetText();
            TBPrecio.ResetText();
            TBSubtotal.ResetText();
            TBDescuento.ResetText();

        }

        private void BTNMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
