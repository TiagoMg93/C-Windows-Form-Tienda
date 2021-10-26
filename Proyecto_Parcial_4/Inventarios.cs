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
    public partial class FMRInventarios : MaterialSkin.Controls.MaterialForm
    {
        string Base_Datos;
        public FMRInventarios(string texto)
        {
            InitializeComponent();
            Base_Datos = texto;
        }

        private void DTGVInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FMRInventarios_Load(object sender, EventArgs e)
        {
            //Iniciamos con conexión a la base de datos y traemos todos los articulos presentes en la tienda
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
            conexion.Open();
            //Se realizan dos tablas con la informacion de la base de datos, una para llenar el Datagridview y otra para llenar
            //el Combo-Box de la busqueda
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select *  from Articulo  left join Proveedor on Articulo.Código = Proveedor.Código", conexion);
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
            //finalmente se limpia la tabla para que almacene el segundo query con el cual se llenará el Datagridview
            tabla.Clear();
            dataAdapter2.Fill(tabla);
            //Creamos un ciclo for para que la información vaya ingresando al Datagridview de forma ordenada por filas
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                DTGVInventario.Rows.Add();
                DTGVInventario.Rows[row].Cells[0].Value = tabla.Rows[row][0].ToString();
                DTGVInventario.Rows[row].Cells[1].Value = tabla.Rows[row][1].ToString();
                DTGVInventario.Rows[row].Cells[2].Value = tabla.Rows[row][3].ToString();
                DTGVInventario.Rows[row].Cells[3].Value = tabla.Rows[row][4].ToString();
                DTGVInventario.Rows[row].Cells[4].Value = tabla.Rows[row][2].ToString();
                DTGVInventario.Rows[row].Cells[5].Value = tabla.Rows[row][6].ToString();
                DTGVInventario.Rows[row].Cells[6].Value = tabla.Rows[row][7].ToString();
                DTGVInventario.Rows[row].Cells[7].Value = tabla.Rows[row][8].ToString();
            }
            conexion.Close();
        }

        private void CBArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lo que se busca es cargar la información que se elija en el Combo-Box dentro de los campos correspondientes
            //creamos un vector que almacene el texto estructurado del Combo-Box y lo dividimos para extraer el codigo
            string[] vector = CBArticulo.Text.Split(' ');
            //se realiza un ciclo for para que compare el articulo elegido del Combo-Box con la lista del Datagridview
            for(int row = 0; row < DTGVInventario.Rows.Count; row++)
            {
                //se usa un condicional que controle que de la lista del datagridview se carga en los campos
                if(DTGVInventario.Rows[row].Cells[0].Value.ToString() == vector[0])
                {
                    TBCodigo.Text = DTGVInventario.Rows[row].Cells[0].Value.ToString();
                    TBArticulo.Text = DTGVInventario.Rows[row].Cells[1].Value.ToString();
                    TBPrecio.Text = DTGVInventario.Rows[row].Cells[2].Value.ToString();
                    TBCosto.Text = DTGVInventario.Rows[row].Cells[3].Value.ToString();
                    TBCantidad.Text = DTGVInventario.Rows[row].Cells[5].Value.ToString();
                    TBMarca.Text = DTGVInventario.Rows[row].Cells[4].Value.ToString();
                    TBProveedor.Text = DTGVInventario.Rows[row].Cells[6].Value.ToString();
                    TBContacto.Text = DTGVInventario.Rows[row].Cells[7].Value.ToString();
                }
            }
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            //se abre el formulario busqueda y se habilita el boton de actualizar busqueda
            FMRBusqueda buscar = new FMRBusqueda(Base_Datos);
            buscar.Show();
            BTNActBusqueda.Enabled = true;
            //Se debe limpiar el Combo-Box para que luego de actualizar lo buscado solo exista esa opción
            CBArticulo.Items.Clear();
        }

        private void BTNActBusqueda_Click(object sender, EventArgs e)
        {
            //En este botón se carga la busqueda previamente realizada y se almacena el articulo en el Combo-Box
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
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

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro que desea modificar la información de este artículo?", "STOP", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (decision == DialogResult.Yes)
            {
                //Con este botón se pretende modificar la información de los artículos ya existentes, para ello empleamos la
                //base de datos y usamos un query que nos permite modificar desde el formulario la información almacenada
                //en la base de datos
                SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
                conexion.Open();
                bool correcto = false;
                while (correcto == false)
                {
                    try
                    {
                        double suma = double.Parse(TBPrecio.Text) + 2;
                        correcto = true;
                    }
                    catch
                    {
                        TBPrecio.Text = Interaction.InputBox("El valor ingresado en el precio no es un número, por favor vuelva a ingresarlo", "ATENCIÓN");
                        correcto = false;
                    }
                }
                correcto = false;
                while (correcto == false)
                {
                    try
                    {
                        double suma = double.Parse(TBCosto.Text) + 2;
                        correcto = true;
                    }
                    catch
                    {
                        TBCosto.Text = Interaction.InputBox("El valor ingresado en el costo no es un número, por favor vuelva a ingresarlo", "ATENCIÓN");
                        correcto = false;
                    }
                }
                correcto = false;
                while (correcto == false)
                {
                    try
                    {
                        int suma = int.Parse(TBContacto.Text) + 2;
                        correcto = true;
                    }
                    catch
                    {
                        TBContacto.Text = Interaction.InputBox("El valor ingresado en el contacto no es un número, por favor vuelva a ingresarlo", "ATENCIÓN");
                        correcto = false;
                    }
                }
                SqlCommand modificar = new SqlCommand(string.Format("Update Articulo set Nombre = '{0}',Precio = {1},Costo = {2},Marca = '{3}' where Código = {4}", TBArticulo.Text, float.Parse(TBPrecio.Text), float.Parse(TBCosto.Text), TBMarca.Text, int.Parse(TBCodigo.Text)), conexion);
                modificar.ExecuteNonQuery();
                modificar = new SqlCommand(string.Format("Update Proveedor set Proveedor = '{0}',Contacto = {1} where Código = {2}", TBProveedor.Text, TBContacto.Text, TBCodigo.Text), conexion);
                modificar.ExecuteNonQuery();
                //Luego de ser almacenados los cambios se debe limpiar los campos para comodidad del usuario
                TBCodigo.ResetText();
                TBArticulo.ResetText();
                TBPrecio.ResetText();
                TBCosto.ResetText();
                TBCantidad.ResetText();
                TBMarca.ResetText();
                TBProveedor.ResetText();
                TBContacto.ResetText();
                CBArticulo.Items.Clear();
                CBArticulo.ResetText();
                //tambien se debe volver a reiniciar el Combo-Box con todos los articulos de la tienda
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
                DataTable tabla = new DataTable();
                dataAdapter.Fill(tabla);
                CBArticulo.Items.Add("");
                for (int row = 0; row < tabla.Rows.Count; row++)
                {
                    string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                    CBArticulo.Items.Add(texto);
                }
                //finalmente se debe cambiar la información mostrada en el datagrid para que se actualice con los 
                //nuevos cambios generados
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select *  from Articulo  left join Proveedor on Articulo.Código = Proveedor.Código", conexion);
                tabla.Clear();
                dataAdapter2.Fill(tabla);
                DTGVInventario.Rows.Clear();
                for (int row = 0; row < tabla.Rows.Count; row++)
                {
                    DTGVInventario.Rows.Add();
                    DTGVInventario.Rows[row].Cells[0].Value = tabla.Rows[row][0].ToString();
                    DTGVInventario.Rows[row].Cells[1].Value = tabla.Rows[row][1].ToString();
                    DTGVInventario.Rows[row].Cells[2].Value = tabla.Rows[row][3].ToString();
                    DTGVInventario.Rows[row].Cells[3].Value = tabla.Rows[row][4].ToString();
                    DTGVInventario.Rows[row].Cells[4].Value = tabla.Rows[row][2].ToString();
                    DTGVInventario.Rows[row].Cells[5].Value = tabla.Rows[row][6].ToString();
                    DTGVInventario.Rows[row].Cells[6].Value = tabla.Rows[row][7].ToString();
                    DTGVInventario.Rows[row].Cells[7].Value = tabla.Rows[row][8].ToString();
                }
                conexion.Close();
                //se deshabilita el botón
                BTNActBusqueda.Enabled = false;
            }
        }
    }
}
