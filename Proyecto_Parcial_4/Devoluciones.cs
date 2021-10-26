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
    public partial class FMRDevoluciones : MaterialSkin.Controls.MaterialForm
    {
        string Base_Datos;
        public FMRDevoluciones(string texto)
        {
            InitializeComponent();
            Base_Datos = texto;
        }

        private void FMRDevoluciones_Load(object sender, EventArgs e)
        {
            //Se cargan la información del combo-Box devoluciones y el Combo-Box eliminar, en el primero se listan los productos
            //que tengan algun inventario y en el segundo los productos que ya no cuentan con inventario disponible
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
            //Se conecta a la base de datos y se abre
            conexion.Open();
            //se extrae la tabla del query de la base de datos para llenar el Combo-Box devoluciones
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select Articulo.Código,Nombre,Marca from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad > 0", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //Se llena el Combo-box devoluciones con la información extraida del query
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
            //Se extrae la tabla del query de la base de datos para llenar el Combo-box eliminar
            dataAdapter = new SqlDataAdapter("select Articulo.Código,Nombre,Marca from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad = 0", conexion);
            DataTable tabla2 = new DataTable();
            dataAdapter.Fill(tabla2);
            //Se llena el Combo-box eliminar con la información extraida del query
            for (int row = 0; row < tabla2.Rows.Count; row++)
            {
                //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                CBEliminar.Items.Add(texto);
            }
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            //se abre el formulario busqueda y se habilita el boton de actualizar busqueda
            FMRBusqueda buscar = new FMRBusqueda(Base_Datos);
            buscar.Show();
            BTNActBusqueda.Enabled = true;
            //Se debe limpiar el Combo-Box para que luego de actualizar lo buscado solo exista esa opción
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //En este botón se carga la busqueda previamente realizada y se almacena el articulo en el Combo-Box
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
            conexion.Open();
            //Dentro de la base de datos existe una tabla de un solo elemento que es la busqueda
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Buscar", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //se estructura un texto acorde a la información del Combo box
            string texto = "";
            try
            {
                texto = tabla.Rows[0]["Busqueda"].ToString();
            }
            catch
            {
                //Si no existe información en la tabla resultante, se informa al usuario
                MessageBox.Show("No hay Busqueda asociada", "INFORMACION");
            }
            //empleamos un try-catch para asegurarnos de que la tabla no este vacia
            for (int item = 0; item < CBEliminar.Items.Count; item++)
            {
                //Se emplea un condicional que constate que existan cantidades suficientes para la devolucion
                if (texto == CBEliminar.Items[item].ToString())
                {
                    MessageBox.Show("El Articulo seleccionado no cuenta con unidades existentes", "INFORMATIVO");
                    CBArticulo.ResetText();
                }
                else
                {
                    //Se limpia el Combo-Box y se agrega el artículo
                    CBArticulo.Items.Clear();
                    CBArticulo.Items.Add(texto);
                    CBArticulo.ResetText();
                }
            }
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se habilitan los botones del texto y el boton de actualizar
            TBUnidades.Enabled = true;
            BTNActualizar.Enabled = true;
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro que desea devolver este artículo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                //Se hace un vextor y se extrae el primer elemento que representa el codigo del articulo a devolver
                string[] vector = CBArticulo.Text.Split(' ');
                //Se emplea un una conexion a la base de datos que permita extraer la cantidad de existencias en el inventario
                //del producto seleccionado.
                SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
                conexion.Open();
                //Se emplea una tabla que traiga el query que trae la cantidad de existencias en el inventario
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(string.Format("Select Cantidad from Proveedor where Código = {0}", vector[0]), conexion);
                DataTable data = new DataTable();
                dataAdapter1.Fill(data);
                //Se evalua las existencias (inventario) que se tienen del articulo, para verificar que si se tengan los suficientes
                if (int.Parse(TBUnidades.Text) > int.Parse(data.Rows[0][0].ToString()))
                {
                    //Se cancela la operación si se identifica que la cantidad de articulos registrados son mayores que
                    //las unidades existentes en la base de datos
                    MessageBox.Show("La operación se cancela, el almacen no cuenta con el inventario suficiente");
                }
                else
                {
                    //En caso contrario se evalua si lo ingresado en el text-box es un número, de lo contrario se sigue pidiendo
                    //hasta que el usuario ingrese un valor correcto
                    bool correcto = false;
                    while (correcto == false)
                    {
                        try
                        {
                            int suma = int.Parse(TBUnidades.Text) + 2;
                            correcto = true;
                        }
                        catch
                        {
                            TBUnidades.Text = Interaction.InputBox("El valor ingresado no es un número, por favor vuelva a ingresarlo", "ATENCIÓN");
                            correcto = false;
                        }
                    }
                    //Se crea un comando sql que modifique la cantidad de existencias del producto devuelto en el inventario
                    SqlCommand modificar = new SqlCommand(string.Format("update Proveedor set Cantidad = Cantidad - {0} where Código = {1}", TBUnidades.Text, vector[0]), conexion);
                    modificar.ExecuteNonQuery();
                }
                //Se reinicia el formulario
                CBArticulo.ResetText();
                CBArticulo.Items.Clear();
                TBUnidades.Clear();
                //Se actualiza el Combo-Box devoluciones
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select Articulo.Código,Nombre,Marca from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad > 0", conexion);
                DataTable tabla = new DataTable();
                dataAdapter.Fill(tabla);
                //Se emplea un texto que entre como un item en el Combo-Box
                for (int row = 0; row < tabla.Rows.Count; row++)
                {
                    //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                    string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                    CBArticulo.Items.Add(texto);
                }
                //se actualiza el Combo-Box eliminar
                dataAdapter = new SqlDataAdapter("select Articulo.Código,Nombre,Marca from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad = 0", conexion);
                DataTable tabla2 = new DataTable();
                dataAdapter.Fill(tabla2);
                for (int row = 0; row < tabla2.Rows.Count; row++)
                {
                    //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                    string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                    CBEliminar.Items.Add(texto);
                }
                //finalmente se inhabilitan los botones
                BTNActualizar.Enabled = false;
                TBUnidades.Enabled = false;
            }
        }

        private void CBEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //habilitar el boton de eliminar
            BTNEliminar.Enabled = true;
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro que desea eliminar este artículo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (decision == DialogResult.Yes)
            {
                //Creamos un vector que contenga el taxto del Combo-Box fragmentado
                string[] vector = CBEliminar.Text.Split(' ');
                //empleamos una conexion sql que permita eliminar una fila mediante un comando sql
                SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
                conexion.Open();
                //ejecutamos el query y por medio de eliminacion por cascada, al eliminar una linea de la tabla Articulo
                //se eliminarán las filas del mismo codigo de las otras tablas
                SqlCommand eliminar_Articulo = new SqlCommand(string.Format("delete from Articulo where Código = {0}", vector[0]), conexion);
                eliminar_Articulo.ExecuteNonQuery();
                //debemos traer la tabla sql resultante de la eliminacion y por ende, contar sus lineas
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Articulo", conexion);
                DataTable tabla = new DataTable();
                dataAdapter.Fill(tabla);
                //se desea reordenar el Codigo de los articulos de la tabla resultante de la eliminacion
                int aumento = 0;
                //nombramos un entero que empieza en 0 para que aumente el digito del codigo despues del salto de codigo
                for (int row = 0; row < tabla.Rows.Count; row++)
                {
                    //empleamos un ciclo for que vaya recorriendo las posiciones del codigo en la tabla donde se encuentran
                    //almacenados los articulos, al emplear un condicional para identificar en que paso por las filas de la tabla
                    //fue la eliminacion del articulo y el codigo tiene un salto numérico
                    if (row + 1 >= int.Parse(vector[0]))
                    {
                        //cuando la fila recorra el elemento siguiente a la eliminación y se aumenta el entero en una unidad, que
                        //sirve para aumentar la columna codigo
                        aumento += 1;
                        //Se empleaa un Comando que modifique el codigo en la tabla sql
                        SqlCommand codigo_Articulo = new SqlCommand(string.Format("update Articulo set Código = {0} where Código = {1}", row + 1, int.Parse(vector[0]) + aumento), conexion);
                        codigo_Articulo.ExecuteNonQuery();
                    }
                    else
                    {
                        //Se le asigna el valor del paso de la fila+1 en la columna codigo
                        SqlCommand codigo_Articulo = new SqlCommand(string.Format("update Articulo set Código = {0} where Código = {0}", row + 1), conexion);
                        codigo_Articulo.ExecuteNonQuery();
                    }
                }
                //Se debe actualizar el Combo-box de eliminación
                dataAdapter = new SqlDataAdapter("select Articulo.Código,Nombre,Marca from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad = 0", conexion);
                DataTable tabla2 = new DataTable();
                dataAdapter.Fill(tabla2);
                for (int row = 0; row < tabla2.Rows.Count; row++)
                {
                    //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                    string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                    CBEliminar.Items.Add(texto);
                }
                //Se reinicia el foormulacio
                CBEliminar.Items.Clear();
                conexion.Close();
                CBEliminar.ResetText();
                BTNEliminar.Enabled = false;
            }
        }
    }
}
