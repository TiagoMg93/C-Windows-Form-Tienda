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
    public partial class FMRBusqueda : MaterialSkin.Controls.MaterialForm
    {
        string Base_Datos;
        public FMRBusqueda(string texto)
        {
            InitializeComponent();
            Base_Datos = texto;
        }

        private void FMRBusqueda_Load(object sender, EventArgs e)
        {
            //Conectamos con la base de datos con una tabla que contiene un unico valor y la limpiamos, alli se almacenará
            //lo encontrado posteriormente por la busqueda, la limpieza se hace para que no se acumulen los datos y asi sea
            //mas facil encontrar el dato en los formularios que hagan el llamado a este
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True",Base_Datos));
            SqlCommand limpiar = new SqlCommand("delete from Buscar", conexion);
            conexion.Open();
            limpiar.ExecuteNonQuery();
            conexion.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CBCodigo_CheckedChanged(object sender, EventArgs e)
        {
            //se realiza un condicional que controle los check que se dan en los CheckBox, donde solo se permita mantener
            //Un checkBox señalado, tambien se controla la habilitacion de la barra de busqueda, asistiendo al usuario en
            //el protocolo de busqueda
            if (CBNombre.Checked == true || CBMarca.Checked == true)
            {
                CBCodigo.Checked = false;
                TBBusqueda.Enabled = true;
            }
            else if (CBCodigo.Checked == false && CBNombre.Checked == false && CBMarca.Checked == false)
            {
                TBBusqueda.Enabled = false;
            }
            else
            {
                TBBusqueda.Enabled = true;
            }
        }

        private void CBNombre_CheckedChanged(object sender, EventArgs e)
        {
            //se realiza un condicional que controle los check que se dan en los CheckBox, donde solo se permita mantener
            //Un checkBox señalado, tambien se controla la habilitacion de la barra de busqueda, asistiendo al usuario en
            //el protocolo de busqueda
            if (CBCodigo.Checked == true || CBMarca.Checked == true)
            {
                CBNombre.Checked = false;
                TBBusqueda.Enabled = true;
            }
            else if (CBCodigo.Checked == false && CBNombre.Checked == false && CBMarca.Checked == false)
            {
                TBBusqueda.Enabled = false;
            }
            else
            {
                TBBusqueda.Enabled = true;
            }
        }

        private void CBBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se habilita el botón que inicia la busqueda en la base de datos
            BTNAceptar.Enabled = true;
        }

        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            //Se vuelve a conectar a la base de datos para almacenar el dato de la busqueda efectuada
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
            //Se crea un comando sql donde se agregue la información que se encuentra en el comboBox
            SqlCommand agregar = new SqlCommand("insert into Buscar values(@Busqueda)", conexion);
            conexion.Open();
            //Se envia el valor del Combo-Box que será agregado a la tabla de busqueda
            agregar.Parameters.AddWithValue("@Busqueda", CBBusqueda.Text);
            agregar.ExecuteNonQuery();
            conexion.Close();
            this.Close();
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            CBBusqueda.Items.Clear();
            //Se hace una conexion con la base de datos en sql
            SqlConnection conexion = new SqlConnection(string.Format("Data Source = {0};Initial Catalog = Tienda;Integrated Security = True", Base_Datos));
            conexion.Open();
            string texto = "";
            //Se agrega un condicional para diferenciar la columna donde se hace la busqueda
            if (CBCodigo.Checked == true)
            {
                //se crea un texto con un formato de query sql, donde se adiciona lo obtenido anteriormente en la caja de texto
                texto = string.Format("Select Código,Nombre,Marca from Articulo where Código like '%{0}%'",TBBusqueda.Text);
            }
            else if (CBNombre.Checked == true)
            {
                texto = string.Format("Select Código,Nombre,Marca from Articulo where Nombre like '%{0}%'",TBBusqueda.Text);
            }
            else
            {
                texto = string.Format("Select Código,Nombre,Marca from Articulo where Marca like '%{0}%'",TBBusqueda.Text);
            }
            //se adapta la tabla sql y luego se llena una tabla de datos con la información
            SqlDataAdapter dataAdapter = new SqlDataAdapter(texto, conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //se usa un ciclo for que recorra las filas de la tabla y asi poder extraer la información
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                string Add_text = tabla.Rows[row]["Código"].ToString() + " - " + tabla.Rows[row]["Nombre"].ToString() + " - " + tabla.Rows[row]["Marca"].ToString();
                CBBusqueda.Items.Add(Add_text);
            }
            //se habilita el ComboBox para localizar el elemento deseado
            CBBusqueda.Enabled = true;
            TBBusqueda.ResetText();
            conexion.Close();
        }

        private void CBMarca_CheckedChanged(object sender, EventArgs e)
        {
            //se realiza un condicional que controle los check que se dan en los CheckBox, donde solo se permita mantener
            //Un checkBox señalado, tambien se controla la habilitacion de la barra de busqueda, asistiendo al usuario del
            //protocolo de busqueda
            if (CBCodigo.Checked == true || CBNombre.Checked == true)
            {
                CBMarca.Checked = false;
                TBBusqueda.Enabled = true;
            }
            else if (CBCodigo.Checked == false && CBNombre.Checked == false && CBMarca.Checked == false)
            {
                TBBusqueda.Enabled = false;
            }
            else
            {
                TBBusqueda.Enabled = true;
            }
        }
    }
}
