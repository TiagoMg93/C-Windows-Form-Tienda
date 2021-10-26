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
    public partial class FRMHistorial : MaterialSkin.Controls.MaterialForm
    {
        string Base_Datos;
        public FRMHistorial(string texto)
        {
            InitializeComponent();
            Base_Datos = texto;
        }

        private void FRMHistorial_Load(object sender, EventArgs e)
        {
            //Se conecta a la base de datos para extraer la información solicitada por el datagridview
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
            conexion.Open();
            //se usa un DataTable para almacenar la tabla extraida por el query de sql
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Articulo.Código,Articulo.Nombre,Historial.Unidades_Vendidas from Articulo inner join Historial on Articulo.Código = Historial.Código", conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //Se emplea un ciclo for para llenar el datagridview por filas
            for(int row = 0; row < tabla.Rows.Count; row++)
            {
                DTGVHistorial.Rows.Add();
                DTGVHistorial.Rows[row].Cells[0].Value = tabla.Rows[row][0].ToString();
                DTGVHistorial.Rows[row].Cells[1].Value = tabla.Rows[row][1].ToString();
                DTGVHistorial.Rows[row].Cells[2].Value = tabla.Rows[row][2].ToString();
            }
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
