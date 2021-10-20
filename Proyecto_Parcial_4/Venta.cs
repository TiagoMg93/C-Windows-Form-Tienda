using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;

namespace Proyecto_Parcial_4
{
    public partial class FRMVenta : Form
    {
        public FRMVenta(bool administrador)
        {
            InitializeComponent();
            //Se compara el argumento recibido del ingreso para saber que funciones se habilitan
            if (administrador == true)
            {
                BTNEliminar.Visible = true;
                BTNMostrar.Visible = true;
                menuStrip1.Enabled = true;
            }
        }

        private void FRMVenta_Load(object sender, EventArgs e)
        {

        }

        private void CBArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lo que se busca es cargar la información que se elija en el Combo-Box dentro de los campos correspondientes
            //creamos un vector que almacene el texto estructurado del Combo-Box y lo dividimos para extraer el codigo
            string[] vector = CBArticulo.Text.Split(' ');
            //Iniciamos con conexión a la base de datos y traemos todos los articulos presentes en la tienda
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //Se adapta una tabla de manera que contenga la información necesaria para ser ejecutado el registro del articulo
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Articulo.Código,Precio,Marca,Descuento from Articulo inner join Descuento on Articulo.Código = Descuento.Código", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //se extrae de la tabla el precio y el descuento del articulo que se encuentra en el Combo-Box
            TBPrecio.Text = tabla.Rows[int.Parse(vector[0])-1][1].ToString();
            TBDescuento.Text = tabla.Rows[int.Parse(vector[0])-1][3].ToString();
            conexion.Close();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            //Se muestra un Mensaje con botones para confirmar la salida del formulario
            DialogResult decision = MessageBox.Show("¿Seguro que desea salir?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (decision == DialogResult.Yes)
            {
                FMRIngreso ingreso = new FMRIngreso();
                ingreso.Show();
                this.Hide();
            }
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            //se abre el formulario busqueda y se habilita el boton de actualizar busqueda
            FMRBusqueda buscar = new FMRBusqueda();
            buscar.Show();
            BTNActBusqueda.Enabled = true;
            //Se debe limpiar el Combo-Box para que luego de actualizar lo buscado solo exista esa opción
            CBArticulo.Items.Clear();
        }

        private void BTNActBusqueda_Click(object sender, EventArgs e)
        {
            //En este botón se carga la busqueda previamente realizada y se almacena el articulo en el Combo-Box
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //Dentro de la base de datos existe una tabla de un solo elemento que es la busqueda
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Buscar", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            string texto = "";
            //empleamos un try-catch para asegurarnos de que la tabla no este vacia
            try
            {
                texto = tabla.Rows[0]["Busqueda"].ToString();
            }
            catch
            {
                MessageBox.Show("No hay Busqueda asociada", "INFORMACION");
            }
            //Se limpia el Combo-Box y se agrega el artículo
            CBArticulo.Items.Clear();
            CBArticulo.Items.Add(texto);
            CBArticulo.ResetText();
        }

        private void BTNCalcular_Click(object sender, EventArgs e)
        {
            bool correcto = false;
            while (correcto == false)
            {
                try
                {
                    double suma = double.Parse(TBCantidad.Text) + 2;
                    correcto = true;
                }
                catch
                {
                    TBCantidad.Text = Interaction.InputBox("El valor ingresado en la cantidad no es un número, por favor vuelva a ingresarlo", "ATENCIÓN");
                    correcto = false;
                }
            }
            //Se emplea un boton Calcular que permita calcular el subtotal por pagar del articulo ingresado y su cantidad
            double valor = double.Parse(TBPrecio.Text)-((double.Parse(TBPrecio.Text) * double.Parse(TBDescuento.Text)) / 100);
            //se debe restar el descuento asociado al articulo.
            TBSubtotal.Text = Convert.ToString(valor * double.Parse(TBCantidad.Text));
            BTNRegistrar.Enabled = true;
        }

        private void BTNRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro que desea registrar este articulo?", "CONSULTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                //Se crea un vector con la información del combo box, para identificar el codigo del articulo
                //de esa forma ir a la base de datos y buscar la información necesaria de ese articulo
                string[] vector = CBArticulo.Text.Split('-');
                SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
                conexion.Open();
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(string.Format("Select Cantidad from Proveedor where Código = {0}", vector[0]), conexion);
                DataTable data = new DataTable();
                dataAdapter1.Fill(data);
                //Se evalua las existencias (inventario) que se tienen del articulo, para verificar que si se tengan los suficientes
                if (int.Parse(TBCantidad.Text) > int.Parse(data.Rows[0][0].ToString()))
                {
                    //Se cancela la operación si se identifica que la cantidad de articulos registrados son mayores que
                    //las unidades existentes en la base de datos
                    MessageBox.Show("La operación se cancela, el almacen no cuenta con el inventario suficiente");
                    CBArticulo.Items.Clear();
                    CBArticulo.ResetText();
                    //Se realizan dos tablas con la informacion de la base de datos, una para  llenar el Combo-Box de la busqueda
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
                    //Creamos una tabla que sera la encargada de interactuar con las tablas generadas por sql y la información del
                    //formulario
                    DataTable tabla2 = new DataTable();
                    //Llenamos el DataTable con la información extraida con el primer query para llenar el Combo-Box
                    dataAdapter2.Fill(tabla2);
                    //agregamos una opcion en el Combo-Box que permita dejar la casilla vacia
                    CBArticulo.Items.Add("");
                    //Creamos un ciclo for para contruir el texto que irá dentro del Combo-Box
                    for (int row = 0; row < tabla2.Rows.Count; row++)
                    {
                        //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                        string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                        CBArticulo.Items.Add(texto);
                    }
                    //Se reinicialos los campos del formulario y se habilita el boton para confirmar toda la compra
                    TBCantidad.Clear();
                    TBPrecio.Clear();
                    TBDescuento.Clear();
                    TBSubtotal.Clear();
                    TBPago.Enabled = true;
                    BTNConfirmar.Enabled = true;
                    BTNActBusqueda.Enabled = false;
                    BTNRegistrar.Enabled = false;
                }
                else
                {
                    int n = DGVVenta.Rows.Add();

                    /*Me guarda los datos al data grid view*/
                    DGVVenta.Rows[n].Cells[0].Value = vector[0][0];
                    DGVVenta.Rows[n].Cells[1].Value = vector[1];
                    DGVVenta.Rows[n].Cells[2].Value = vector[2];
                    DGVVenta.Rows[n].Cells[3].Value = TBPrecio.Text;
                    DGVVenta.Rows[n].Cells[4].Value = Convert.ToString((double.Parse(TBPrecio.Text) * double.Parse(TBDescuento.Text)) / 100);
                    DGVVenta.Rows[n].Cells[5].Value = TBCantidad.Text;
                    DGVVenta.Rows[n].Cells[6].Value = TBSubtotal.Text;
                    double total = 0;
                    //Se emplea una variable que acumule los subtotales
                    for (int row = 0; row < DGVVenta.Rows.Count; row++)
                    {
                        total += double.Parse(DGVVenta.Rows[row].Cells[6].Value.ToString());
                    }
                    TBTotal.Text = Convert.ToString(total);
                    //Se reinicia el Combo-Box
                    CBArticulo.Items.Clear();
                    CBArticulo.ResetText();
                    //Se realizan dos tablas con la informacion de la base de datos, una para  llenar el Combo-Box de la busqueda
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
                    //Creamos una tabla que sera la encargada de interactuar con las tablas generadas por sql y la información del
                    //formulario
                    DataTable tabla = new DataTable();
                    //Llenamos el DataTable con la información extraida con el primer query para llenar el Combo-Box
                    dataAdapter.Fill(tabla);
                    //agregamos una opcion en el Combo-Box que permita dejar la casilla vacia
                    CBArticulo.Items.Add("");
                    //Creamos un ciclo for para contruir el texto que irá dentro del Combo-Box
                    for (int row = 0; row < tabla.Rows.Count; row++)
                    {
                        //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                        string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                        CBArticulo.Items.Add(texto);
                    }
                    //Finalmente se debe limpiar los textbox 
                    TBCantidad.Clear();
                    TBPrecio.Clear();
                    TBDescuento.Clear();
                    TBSubtotal.Clear();
                    TBPago.Enabled = true;
                    BTNConfirmar.Enabled = true;
                    BTNActBusqueda.Enabled = false;
                    BTNRegistrar.Enabled = false;
                    BTNNuevo.Enabled = true;
                    BTNEliminar.Enabled = true;
                }
            }
        }

        private void TBTotal_TextChanged(object sender, EventArgs e)
        {

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

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            //Se emplea un botón para registrar una venta nueva, de esta forma se resetea todo el formulario
            //para llevar acabo la nueva venta
            DGVVenta.Rows.Clear();
            TBCantidad.Clear();
            TBPrecio.Clear();
            TBDescuento.Clear();
            TBSubtotal.Clear();
            TBTotal.Clear();
            TBCambio.Clear();
            BTNCalcular.Enabled = true;
            TBCantidad.Enabled = true;
            BTNNuevo.Enabled = false;
            BTNEliminar.Enabled = false;
            BTNCalcular.Enabled = true;
            BTNBuscar.Enabled = true;
            CBArticulo.Enabled = true;
            //Iniciamos con conexión a la base de datos y traemos todos los articulos presentes en la tienda
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //Se realizan dos tablas con la informacion de la base de datos, una para  llenar el Combo-Box de la busqueda
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
            //Creamos una tabla que sera la encargada de interactuar con las tablas generadas por sql y la información del
            //formulario
            DataTable tabla = new DataTable();
            //Llenamos el DataTable con la información extraida con el primer query para llenar el Combo-Box
            dataAdapter.Fill(tabla);
            //Creamos un ciclo for para contruir el texto que irá dentro del Combo-Box
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            //Se emplea un boton para eliminar un articulo ya listado en el datagridview, de esta forma
            //si hay un error humano a la hora de seleccionar, se puede corregir antes de generarse la venta final
            string decision = Interaction.InputBox("Ingrese el CÓDIGO del producto a eliminar del registro", "ELIMINAR");
            //se le pregunta al usuario cual producto quiere eliminar, a partir de su codigo
            int row = 0;
            bool encontrar = false;
            //se usa un ciclo while con un entero que recorra las filas del datagridview y un booleano que verifique
            //que el codigo ingresado si se haya listado en el datagridview
            while(row<DGVVenta.Rows.Count && encontrar == false)
            {
                //Se emplea un condicional que verifique si el codigo ingresado por el usuario concuerde con un articulo
                //del datagridview
                if(decision == DGVVenta.Rows[row].Cells[0].Value.ToString())
                {
                    //al encontrarlo se cambia el valor booleano para salir del ciclo y se elimina la fila
                    encontrar = true;
                    DGVVenta.Rows.RemoveAt(row);
                }
                row += 1;
            }
            //saliendo del ciclo se emplea un condicional para advertir al usuario de que ingreso incorrectamente
            //el codigo
            if(encontrar == false)
            {
                MessageBox.Show("El CÓDIGO ingresado no estaba registrado", "INFORMACIÓN");
            }
            else
            {
                //de lo contrario, se actualiza el total a pagar con lo que queda del datagridview
                double total = 0;
                for (int fila = 0; fila < DGVVenta.Rows.Count; fila++)
                {
                    total += double.Parse(DGVVenta.Rows[fila].Cells[6].Value.ToString());
                }
                TBTotal.Text = Convert.ToString(total);
            }
        }

        private void BTNConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro que desea Confirmar esta venta?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                //Se verifica que el empleado ingrese correctamente el pago realizado por el cliente final
                bool correcto = false;
                while (correcto == false)
                {
                    try
                    {
                        double suma = double.Parse(TBPago.Text) + 2;
                        correcto = true;
                    }
                    catch
                    {
                        TBPago.Text = Interaction.InputBox("El valor ingresado en el pago del cliente no es un número, por favor vuelva a ingresarlo", "ATENCIÓN");
                        correcto = false;
                    }
                }
                //Se calcula el cambio que se le debe entregar al cliente final de acuerdo a lo pagado
                double cambio = double.Parse(TBPago.Text) - double.Parse(TBTotal.Text);
                TBCambio.Text = cambio.ToString();
                //Se abre la base de datos para actualizar las unidades existentes y el historial de ventas
                SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
                conexion.Open();
                //se emplea un data table que traiga el query necesario para actualizar el historial
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Costo from Articulo", conexion);
                DataTable tabla = new DataTable();
                dataAdapter.Fill(tabla);
                //se usa un ciclo for que recorra las filas del datagridview
                for (int row = 0; row < DGVVenta.Rows.Count; row++)
                {
                    //inicialmente se extraen en variables los valores del costo total por las unidades vendidas, el número
                    //de unidades vendidas, el total de las ventas y el codigo de cada artículo
                    double Costo = double.Parse(tabla.Rows[int.Parse(DGVVenta.Rows[row].Cells[0].Value.ToString()) - 1][0].ToString()) * double.Parse(DGVVenta.Rows[row].Cells[5].Value.ToString());
                    int unidades_venta = int.Parse(DGVVenta.Rows[row].Cells[5].Value.ToString());
                    double Venta = double.Parse(DGVVenta.Rows[row].Cells[6].Value.ToString());
                    int codigo = int.Parse(DGVVenta.Rows[row].Cells[0].Value.ToString());
                    //se emplea un comando sql para modificar los valores de la tabla que contiene el historial de ventas
                    SqlCommand modificar = new SqlCommand(string.Format("update Historial set Unidades_Vendidas = Unidades_Vendidas + {0},Ventas_Totales = Ventas_Totales + {1}, Costo_Total = Costo_Total + {2} Where Código = {3}", unidades_venta, Venta, Costo, codigo), conexion);
                    modificar.Parameters.Clear();
                    modificar.ExecuteNonQuery();
                    //se emplea un comando sql para modificar las existencias del inventario de los articulos ya vendidos en el datagridview
                    SqlCommand extraer = new SqlCommand(string.Format("update Proveedor set Cantidad = Cantidad - {0} where Codigo = {1}", unidades_venta, codigo), conexion);
                    extraer.Parameters.Clear();
                    extraer.ExecuteNonQuery();
                }
                //se resetea el formulario
                TBTotal.ResetText();
                TBPago.ResetText();
                DGVVenta.Rows.Clear();
                TBPago.Enabled = false;
                BTNConfirmar.Enabled = false;
                TBCantidad.Enabled = false;
                BTNBuscar.Enabled = false;
                BTNEliminar.Enabled = false;
                BTNCalcular.Enabled = false;
                BTNBuscar.Enabled = false;
                CBArticulo.Enabled = false;
            }
        }

        private void BTNMostrar_Click(object sender, EventArgs e)
        {
            /*[f_infor]:Formulario informe
            me abre el formulario informes*/
            FMRInformes f_infor = new FMRInformes();
            f_infor.Show();
        }
    }
}
