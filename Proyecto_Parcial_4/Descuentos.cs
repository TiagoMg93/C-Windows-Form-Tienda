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
    public partial class FMRDescuentos : Form
    {
        public FMRDescuentos()
        {
            InitializeComponent();
        }

        private void FMRDescuentos_Load(object sender, EventArgs e)
        {
            //Se deben cargar los productos que tengan algun descuento en de datagridview, empleamos la conexion con la base
            //de datos y ejecutamos el query correspondiente para generar una tabla anidada que muestre la información
            //solicitada por el datagridview
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select Articulo.Código,Nombre,Marca,Descuento from Articulo inner join Descuento on Articulo.Código = Descuento.Código Where Descuento > 0 ", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //Empleamos un ciclo for para llenar el datagridview por filas, asegurandonos de colocar correctamente las 
            //posiciones de los datos ingresados
            for(int row = 0; row < tabla.Rows.Count; row++)
            {
                DTGVDescuento.Rows.Add();
                DTGVDescuento.Rows[row].Cells[0].Value = tabla.Rows[row][0].ToString();
                DTGVDescuento.Rows[row].Cells[1].Value = tabla.Rows[row][1].ToString();
                DTGVDescuento.Rows[row].Cells[2].Value = tabla.Rows[row][2].ToString();
                DTGVDescuento.Rows[row].Cells[3].Value = tabla.Rows[row][3].ToString();
            }
            //Seguimos con el llenado del Combo-Box con todos los artículos que se tienen en la tienda
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
            //Creamos una tabla que sera la encargada de interactuar con las tablas generadas por sql y la información del
            //formulario
            DataTable tabla2 = new DataTable();
            //Llenamos el DataTable con la información extraida con el primer query para llenar el Combo-Box
            dataAdapter2.Fill(tabla2);
            //Creamos un ciclo for para contruir el texto que irá dentro del Combo-Box
            for (int row = 0; row < tabla2.Rows.Count; row++)
            {
                //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
        }

        private void DTGVDescuento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se habilitan el boton correspondiente al agregado y el campo de texto donde se ingresa el descuento
            TBDescuento.Enabled = true;
            BTNAgregar.Enabled = true;
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

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            //Se muestra un Mensaje con botones para confirmar la salida del formulario
            DialogResult decision = MessageBox.Show("¿Seguro que desea salir?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (decision == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            DialogResult decision = MessageBox.Show("¿Seguro que desea asociar ese descuento al producto?", "ATENCIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decision == DialogResult.Yes)
            {
                //Se limpia el datagridview
                DTGVDescuento.Rows.Clear();
                //se emplea la conexion a la base de datos
                SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
                conexion.Open();
                //se divide el texto que se encuentra en el Combo-Box, de esa forma podemos extraer el codigo del producto 
                //señalado por el usuario
                string[] vector = CBArticulo.Text.Split(' ');
                //Creamos un booleano que se usara en un ciclo while para verificar que lo ingresado por el usuario es un número
                bool correcto = false;
                while(correcto == false)
                {
                    try
                    {
                        int suma = int.Parse(TBDescuento.Text) + 2;
                        correcto = true;
                    }
                    catch
                    {
                        TBDescuento.Text = Interaction.InputBox("El valor ingresado no es un número, por favor vuelva a ingresarlo", "ATENCIÓN");
                        correcto = false;
                    }
                }
                //Realizamos un comando sql que permite modificar el valor que se encuentra en la tabla de descuento
                SqlCommand actualizar = new SqlCommand(string.Format("update Descuento set Descuento = {0} Where Código = {1}", int.Parse(TBDescuento.Text), int.Parse(vector[0])), conexion);
                actualizar.ExecuteNonQuery();
                //Actualizamos la tabla de descuento con el nuevo articulo con descuento
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select Articulo.Código,Nombre,Marca,Descuento from Articulo inner join Descuento on Articulo.Código = Descuento.Código Where Descuento > 0 ", conexion);
                DataTable tabla = new DataTable();
                dataAdapter.Fill(tabla);
                //volvemos a llenar el datagridview por filas
                for (int row = 0; row < tabla.Rows.Count; row++)
                {
                    DTGVDescuento.Rows.Add();
                    DTGVDescuento.Rows[row].Cells[0].Value = tabla.Rows[row][0].ToString();
                    DTGVDescuento.Rows[row].Cells[1].Value = tabla.Rows[row][1].ToString();
                    DTGVDescuento.Rows[row].Cells[2].Value = tabla.Rows[row][2].ToString();
                    DTGVDescuento.Rows[row].Cells[3].Value = tabla.Rows[row][3].ToString();
                }
                CBArticulo.Items.Clear();
                //Llenamos el Combo-Box de nuevo, para asegurarnos de tener a disposicion todos los productos
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
                //Creamos una tabla que sera la encargada de interactuar con las tablas generadas por sql y la información del
                //formulario
                DataTable tabla2 = new DataTable();
                //Llenamos el DataTable con la información extraida con el primer query para llenar el Combo-Box
                dataAdapter2.Fill(tabla2);
                //Creamos un ciclo for para contruir el texto que irá dentro del Combo-Box
                for (int row = 0; row < tabla2.Rows.Count; row++)
                {
                    //Elegimos la estructura del texto y se agrega a los elementos del Combo-Box
                    string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                    CBArticulo.Items.Add(texto);
                }
                //Se reinicia el formulario para darle la posibilidad al usuario de ingresar mas descuentos hacia los
                //productos existentes
                CBArticulo.ResetText();
                TBDescuento.Clear();
                BTNActBusqueda.Enabled = false;
                TBDescuento.Enabled = false;
                BTNAgregar.Enabled = false;
            }
        }
    }
}
