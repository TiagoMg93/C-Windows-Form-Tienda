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
    public partial class FMRInformes : MaterialSkin.Controls.MaterialForm
    {
        string Base_Datos;
        public FMRInformes(string texto)
        {
            InitializeComponent();
            Base_Datos = texto;
        }

        private void FMRInformes_Load(object sender, EventArgs e)
        {
            //Se usa la conexion a la base de datos para cargar la información requerida por el formulario
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
            conexion.Open();
            //Primero se hace el query correspondiente a las ventas totales que se encuentran en la tabla Historial
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select Sum(Ventas_Totales) from Historial", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            LBVentas.Text = tabla.Rows[0][0].ToString();
            //Primero se hace el query correspondiente al costo total de los articulos vendidos que se encuentran
            //en la tabla Historia
            dataAdapter = new SqlDataAdapter("select Sum(Ventas_Totales)-sum(Costo_Total) from Historial", conexion);
            tabla.Rows.Clear();
            dataAdapter.Fill(tabla);
            LBGanancias.Text = tabla.Rows[0][0].ToString();
            //Se busca en la tabla Historial en la columna unidades vendidas, cual es el articulo que mas ventas tiene
            dataAdapter = new SqlDataAdapter("select Top 1 Articulo.Nombre,Unidades_Vendidas from Articulo inner join Historial on Articulo.Código = Historial.Código order by Unidades_Vendidas DESC", conexion);
            tabla.Rows.Clear();
            dataAdapter.Fill(tabla);
            LBArtMas.Text = string.Format("{0} ({1})", tabla.Rows[0][1].ToString(), tabla.Rows[0][2].ToString());
            //Se busca en la tabla Historial en la columna unidades vendidas, cual es el articulo que menos ventas tiene
            dataAdapter = new SqlDataAdapter("select Top 1 Articulo.Nombre,Unidades_Vendidas from Articulo inner join Historial on Articulo.Código = Historial.Código order by Unidades_Vendidas ASC", conexion);
            tabla.Rows.Clear();
            dataAdapter.Fill(tabla);
            LBArtMen.Text = string.Format("{0} ({1})", tabla.Rows[0][1].ToString(), tabla.Rows[0][2].ToString());
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            //Mensaje de advertencia por el cierre de la app
            DialogResult decision = MessageBox.Show("¿Seguro que desea salir?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (decision == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
