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

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            FMRBusqueda buscar = new FMRBusqueda();
            buscar.Show();
            BTNActBusqueda.Enabled = true;
            CBArticulo.Items.Clear();
            TBArticulo.ResetText();
        }

        private void FMRProveedores_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Código,Nombre,Marca from Articulo", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            CBArticulo.Items.Add("");
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
            conexion.Close();
        }

        private void TBUnidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            string[] vector = CBArticulo.Text.Split('-');
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Proveedor", conexion);
            SqlCommand limpiar = new SqlCommand("Delete from Proveedor", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
        }

        private void BTNActBusqueda_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Buscar", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            string texto = "";
            try
            {
                texto = tabla.Rows[0]["Busqueda"].ToString();
            }
            catch
            {
                MessageBox.Show("No hay Busqueda asociada","INFORMACION");
            }
            CBArticulo.Items.Clear();
            CBArticulo.Text = texto;
            CBArticulo.Items.Add("");
            CBArticulo.Items.Add(texto);
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
