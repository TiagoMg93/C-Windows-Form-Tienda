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

namespace Proyecto_Parcial_4
{
    public partial class FMRProveedores : Form
    {
        public FMRProveedores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CBArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se controla las funcionalidades del Usuario para de esa forma no alterar el buen manejo de la app
            TBUnidades.Enabled = true;
            BTNActualizar.Enabled = true;
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            //se abre el formulario busqueda y se habilita el boton de actualizar busqueda
            FMRBusqueda buscar = new FMRBusqueda();
            buscar.Show();
            BTNActBusqueda.Enabled = true;
            //Se debe limpiar el Combo-Box para que luego de actualizar lo buscado solo exista esa opción
            CBArticulo.Items.Clear();
            TBArticulo.ResetText();
        }

        private void FMRProveedores_Load(object sender, EventArgs e)
        {
            //Se emplea una conexión con la base de datos que permita extraer la información necesaria para 
            //llenar el Combo-Box y el Datagridview
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //se emplean dos querys y para cada una se emplea un data-atapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select Nombre,Marca,Contacto from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad = 0", conexion);
            //Se crea una tabla que almacene los datos de cada dataadapter
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //Se hace la carga de un codigo obligatorio para el agregado de articulo
            TBCodigo.Text = Convert.ToString(tabla.Rows.Count + 1);
            CBArticulo.Items.Add("");
            //Se emplea un ciclo for para construir el texto que debe ir en el Combo-Box
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
            //Se limpia la tabla para reutilizarla en el segundo query, con el cual se llena el datagridview
            tabla.Clear();
            dataAdapter2.Fill(tabla);
            //empleamos un ciclo for para llenar el datagridview con la informacion correspondiente y en la posición correcta
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = tabla.Rows[row]["Nombre"].ToString();
                dataGridView1.Rows[row].Cells[1].Value = tabla.Rows[row]["Marca"].ToString();
                dataGridView1.Rows[row].Cells[2].Value = tabla.Rows[row]["Contacto"].ToString();
            }
            conexion.Close();
        }

        private void TBUnidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            //creamos un vector que desfragmente el texto construido en el Combo-Box
            string[] vector = CBArticulo.Text.Split(' ');
            //se emplea una nueva conexion con la base de datos
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //se crea un comando que se usará en la base de datos, en el cual se borrará la información existente
            SqlCommand limpiar = new SqlCommand("delete from Proveedor", conexion);
            //se crea un data-atapter con el query de toda la tabla
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Proveedor", conexion);
            //se crea un data-table para que almacene la busqueda realizada en el data-adapter
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //ejecutamos el comando de borrado en los datos de sql
            limpiar.ExecuteNonQuery();
            //se crea un nuevo comando sql que permite agregar información a la tabla previamente borrada
            SqlCommand agregar = new SqlCommand("insert into Proveedor values(@Codigo,@Cantidad,@Proveedor,@Contacto)", conexion);
            //se crea un ciclo for que permite llenar la tabla sql con la información almacenada en el data-table
            for(int row = 0; row < tabla.Rows.Count; row++)
            {
                agregar.Parameters.Clear();
                agregar.Parameters.AddWithValue("@Codigo", tabla.Rows[row][0].ToString());
                //se emplea un condicional que permite controlar la celda modificada por el usuario, de esta forma agrega
                //la modificación de la información
                if(tabla.Rows[row][0].ToString() == vector[0])
                {
                    int nuevo = int.Parse(tabla.Rows[row][1].ToString()) + int.Parse(TBUnidades.Text);
                    agregar.Parameters.AddWithValue("@Cantidad", Convert.ToString(nuevo));
                }
                else
                {
                    agregar.Parameters.AddWithValue("@Cantidad", tabla.Rows[row][1].ToString());
                }
                agregar.Parameters.AddWithValue("@Proveedor", tabla.Rows[row][2].ToString());
                agregar.Parameters.AddWithValue("@Contacto", tabla.Rows[row][3].ToString());
                agregar.ExecuteNonQuery();
            }
            //finalmente limpiamos el Combo-Box para reiniciarlo
            CBArticulo.Items.Clear();
            //Se usa el código con el que se llenó los textos del combo-box
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
            DataTable tabla2 = new DataTable();
            dataAdapter2.Fill(tabla2);
            CBArticulo.Items.Add("");
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
            //se reinicia el formulario en sus campos de ingreso
            CBArticulo.ResetText();
            TBUnidades.ResetText();
            TBUnidades.Enabled = false;
            BTNActualizar.Enabled = false;
            //limpiamos el Data-table que se ha venido usando
            tabla.Clear();
            //limpiamos el datagridview
            dataGridView1.Rows.Clear();
            //empleamos el query que se uso para llenar el datagridview, de esa forma se actualiza con los nuevos cambios
            //en la base de datos
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter("Select Nombre,Marca,Contacto from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad = 0", conexion);
            dataAdapter3.Fill(tabla);
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = tabla.Rows[row]["Nombre"].ToString();
                dataGridView1.Rows[row].Cells[1].Value = tabla.Rows[row]["Marca"].ToString();
                dataGridView1.Rows[row].Cells[2].Value = tabla.Rows[row]["Contacto"].ToString();
            }
            conexion.Close();
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
                MessageBox.Show("No hay Busqueda asociada","INFORMACION");
            }
            //Se limpia el Combo-Box y se agrega el artículo
            CBArticulo.Items.Clear();
            CBArticulo.Text = texto;
            CBArticulo.Items.Add("");
            CBArticulo.Items.Add(texto);
            TBUnidades.Enabled = true;
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

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
            //Empleamos este boton para reiniciar los campos de textbox, por comodidad para el usuario
            TBArticulo.ResetText();
            TBPrecio.ResetText();
            TBCosto.ResetText();
            TBCantidad.ResetText();
            TBMarca.ResetText();
            TBProveedor.ResetText();
            TBContacto.ResetText();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            //Se emplea una conexión con la base de datos para agregar la nueva información del nuevo producto
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //usamos un data adapter que traiga la tabla de productos ya existente
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Articulo", conexion);
            DataTable tabla = new DataTable();
            //se llena un Data-Table que permita manejar la información extraida anteriormente
            dataAdapter.Fill(tabla);
            //creamos un comando sql que nos permita ingresar la información del nuevo producto
            SqlCommand agregar = new SqlCommand("Insert into Articulo values(@Código,@Nombre,@Precio,@Costo,@Marca)", conexion);
            tabla.Rows.Add();
            //se agrega una fila en el Data-table y se emplea un indicador que es quien apunta a la nueva fila
            int fila = tabla.Rows.Count-1;
            //se agregan los campos en la fila nueva
            tabla.Rows[fila][0] = TBCodigo.Text;
            tabla.Rows[fila][1] = TBArticulo.Text;
            tabla.Rows[fila][2] = TBPrecio.Text;
            tabla.Rows[fila][3] = TBCosto.Text;
            tabla.Rows[fila][4] = TBMarca.Text;
            //luego se emplea el comando sql para mandar la nueva información a la tabla extraida y de esa manera actualizarla
            agregar.Parameters.AddWithValue("@Código", tabla.Rows[fila][0].ToString());
            agregar.Parameters.AddWithValue("@Nombre", tabla.Rows[fila][1].ToString());
            agregar.Parameters.AddWithValue("@Precio", tabla.Rows[fila][2].ToString());
            agregar.Parameters.AddWithValue("@Costo", tabla.Rows[fila][3].ToString());
            agregar.Parameters.AddWithValue("@Marca", tabla.Rows[fila][4].ToString());
            agregar.ExecuteNonQuery();
            //para poder actualizar toda la base de datos, hay que actualizar todas las tablas
            agregar = new SqlCommand("Insert into Proveedor values(@Código,@Cantidad,@Proveedor,@Contacto)", conexion);
            //se emplea otro comando para agregar la información en la nueva fila de información correspondiente al nuevo
            //producto
            dataAdapter = new SqlDataAdapter("Select * from Proveedor",conexion);
            //se crea una nueva tabla que almacene la información ya existente de la tabla
            DataTable tabla_proveedor = new DataTable();
            dataAdapter.Fill(tabla_proveedor);
            //se agrega en el Data-Table la nueva información correspondiente al nuevo producto
            tabla_proveedor.Rows.Add();
            tabla_proveedor.Rows[fila][0] = TBCodigo.Text;
            tabla_proveedor.Rows[fila][1] = TBCantidad.Text;
            tabla_proveedor.Rows[fila][2] = TBProveedor.Text;
            tabla_proveedor.Rows[fila][3] = TBContacto.Text;
            //se agrega en la tabla de la base de datos la nueva información
            agregar.Parameters.AddWithValue("@Código", tabla_proveedor.Rows[fila][0].ToString());
            agregar.Parameters.AddWithValue("@Cantidad", tabla_proveedor.Rows[fila][1].ToString());
            agregar.Parameters.AddWithValue("@Proveedor", tabla_proveedor.Rows[fila][2].ToString());
            agregar.Parameters.AddWithValue("@Contacto", tabla_proveedor.Rows[fila][3].ToString());
            agregar.ExecuteNonQuery();
            //Se emplea otro comando para otra tabla
            agregar = new SqlCommand("Insert into Descuento values(@Código,@Descuento)", conexion);
            dataAdapter = new SqlDataAdapter("Select * from Descuento", conexion);
            DataTable tabla_descuento = new DataTable();
            //se crea una nueva tabla que contenga la información ya existente en la base de datos
            dataAdapter.Fill(tabla_descuento);
            //se llena el Data-table que luego se usará para llenar la tabla sql
            tabla_descuento.Rows.Add();
            tabla_descuento.Rows[fila][0] = TBCodigo.Text;
            tabla_descuento.Rows[fila][1] = 0;
            //Se llena la tabla sql con el comando creado
            agregar.Parameters.AddWithValue("@Código", tabla_descuento.Rows[fila][0].ToString());
            agregar.Parameters.AddWithValue("@Descuento", tabla_descuento.Rows[fila][1].ToString());
            agregar.ExecuteNonQuery();
            //Se crea otro comando sql que permita llenar la ultima tabla con la información del nuevo producto
            agregar = new SqlCommand("Insert into Historial values(@Código,@Unidades_Vendidas,@Ventas_Totales,@Costo_Total)",conexion);
            dataAdapter = new SqlDataAdapter("Select * from Historial", conexion);
            DataTable tabla_historial = new DataTable();
            //se crea un nuevo Data-Table
            dataAdapter.Fill(tabla_historial);
            //se llena el Data-Table con la nueva información
            tabla_historial.Rows.Add();
            tabla_historial.Rows[fila][0] = TBCodigo.Text;
            tabla_historial.Rows[fila][1] = 0;
            tabla_historial.Rows[fila][2] = 0;
            tabla_historial.Rows[fila][3] = 0;
            //empleando el comando se traslada la información agregada en el Data-Table a la tabla de la base de datos
            agregar.Parameters.AddWithValue("@Código", tabla_historial.Rows[fila][0].ToString());
            agregar.Parameters.AddWithValue("@Unidades_Vendidas", tabla_historial.Rows[fila][1].ToString());
            agregar.Parameters.AddWithValue("@Ventas_Totales", tabla_historial.Rows[fila][2].ToString());
            agregar.Parameters.AddWithValue("@Costo_Total", tabla_historial.Rows[fila][3].ToString());
            agregar.ExecuteNonQuery();
            //Se limpia el Combo-Box y se actualizan los productos
            CBArticulo.Items.Clear();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
            DataTable tabla2 = new DataTable();
            dataAdapter2.Fill(tabla2);
            CBArticulo.Items.Add("");
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                string texto = tabla2.Rows[row]["Código"].ToString() + " - " + tabla2.Rows[row]["Nombre"].ToString() + " - " + tabla2.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
            conexion.Close();
            //En el apartado de código se aumenta, lo que representa un codigo nuevo para un posible producto
            TBCodigo.Text = Convert.ToString(int.Parse(TBCodigo.Text) + 1);
            //se reinician todos los campos de text box
            TBArticulo.ResetText();
            TBPrecio.ResetText();
            TBCosto.ResetText();
            TBCantidad.ResetText();
            TBMarca.ResetText();
            TBProveedor.ResetText();
            TBContacto.ResetText();
        }
    }
}
