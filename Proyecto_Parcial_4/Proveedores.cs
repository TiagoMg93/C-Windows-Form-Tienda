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
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select Nombre,Marca,Contacto from Articulo inner join Proveedor on Articulo.Código = Proveedor.Código where Cantidad = 0", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            TBCodigo.Text = Convert.ToString(tabla.Rows.Count + 1);
            CBArticulo.Items.Add("");
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                string texto = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                CBArticulo.Items.Add(texto);
            }
            tabla.Clear();
            dataAdapter2.Fill(tabla);
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
            string[] vector = CBArticulo.Text.Split('-');
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Proveedor", conexion);
            SqlCommand limpiar = new SqlCommand("Delete from Proveedor", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            limpiar.ExecuteNonQuery();
            SqlCommand agregar = new SqlCommand("insert into Proveedor values(@Código,@Cantidad,@Proveedor,@Contacto)", conexion);
            for(int row = 0; row < tabla.Rows.Count; row++)
            {
                agregar.Parameters.Clear();
                agregar.Parameters.AddWithValue("@Código", tabla.Rows[row][0].ToString());
                if(tabla.Rows[row][0].ToString()+" " == vector[0])
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
            CBArticulo.ResetText();
            TBUnidades.ResetText();
            conexion.Close();
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
            //Se muestra un Mensaje con botones para confirmar la salida del formulario
            DialogResult decision = MessageBox.Show("¿Seguro que desea salir?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (decision == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BTNLimpiar_Click(object sender, EventArgs e)
        {
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

        }
    }
}
