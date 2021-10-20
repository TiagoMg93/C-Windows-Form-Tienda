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
    public partial class FMRUsuarios : Form
    {
        public FMRUsuarios()
        {
            InitializeComponent();
        }
        //Se emplea una varible global para capturar las modificaciones que el usuario desee hacer
        string decision;

        private void DTGVUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FMRUsuarios_Load(object sender, EventArgs e)
        {
            //Se emplea la conexion con la base de datos para llenar el datagridview con la información almacenada en la tabla
            //Usuario
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //Se emplea un Data-Table que permita capturar lo buscado con el query
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Usuario", conexion);
            DataTable tabla = new DataTable();
            //Se llena el datagridview por filas
            dataAdapter.Fill(tabla);
            for (int row = 0; row < tabla.Rows.Count; row++)
            {
                DTGVUsuario.Rows.Add();
                DTGVUsuario.Rows[row].Cells[0].Value = tabla.Rows[row][0].ToString();
                DTGVUsuario.Rows[row].Cells[1].Value = tabla.Rows[row][1].ToString();
                //Se emplea un condicional para transformar el valor en el sql por un texto mas entendible para el usuario
                if (tabla.Rows[row][3].ToString() == "True")
                {
                    DTGVUsuario.Rows[row].Cells[2].Value = "Si";
                }
                else
                {
                    DTGVUsuario.Rows[row].Cells[2].Value = "No";
                }
            }
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
            DialogResult decision = MessageBox.Show("¿Seguro que desea agregar este usuario?", "AGREGAR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (decision == DialogResult.Yes)
            {
                //Se crea un entero que almacene el indice del nuevo usuario a agregar
                int indice = DTGVUsuario.Rows.Count + 1;
                DTGVUsuario.Rows.Add();
                //Se agrega una fila en el datagridview y se llena todo en el campo correspondiente
                DTGVUsuario.Rows[indice - 1].Cells[0].Value = indice;
                DTGVUsuario.Rows[indice - 1].Cells[1].Value = TBUser.Text.ToUpper();
                DTGVUsuario.Rows[indice - 1].Cells[2].Value = CBAdmin.Text;
                //se emplea una variable y un condicional apra transformar el texto del datagridview en un valor
                //que la tabla Usuario en su columna administrador pueda reconocer
                int admin = 0;
                if (CBAdmin.Text == "Si")
                {
                    admin = 1;
                }
                //Se emplea una conexion con la base de datos para actualizar la tabla de Usuarios
                SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
                conexion.Open();
                //Se emplea un comando sql que agregue la información en una fila nueva
                SqlCommand agregar = new SqlCommand("insert into Usuario values(@Indice,@Usuario,@Contraseña,@Administrador)", conexion);
                agregar.Parameters.AddWithValue("@Indice", indice);
                agregar.Parameters.AddWithValue("@Usuario", TBUser.Text.ToUpper());
                agregar.Parameters.AddWithValue("@Contraseña", TBPassword.Text.ToUpper());
                agregar.Parameters.AddWithValue("@Administrador", admin);
                agregar.ExecuteNonQuery();
                conexion.Close();
                //Se resetea el formulario
                TBUser.Clear();
                TBPassword.Clear();
                CBAdmin.ResetText();
            }
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            //Se pregunta el indice del usuario que desea modificar
            decision = Interaction.InputBox("Ingrese el Indice del usuario a modificar", "CAMBIAR");
            //Se abre una conexion con la base de datos para extraer la contraseña del usuario que se va a modificar
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(string.Format("select Contraseña from Usuario where Indice = {0}", decision), conexion);
            DataTable tabla = new DataTable();
            dataAdapter.Fill(tabla);
            //Se usa un ciclo for para buscar en el datagrid el indice correspondiente al usuario que se va a modificar
            int row = 0;
            bool encontrar = false;
            //Se compara el indice ingresado por el usuario con los indices de la tabla usuarios
            while (row < DTGVUsuario.Rows.Count && encontrar == false)
            {
                if (DTGVUsuario.Rows[row].Cells[0].Value.ToString() == decision)
                {
                    TBUser.Text = DTGVUsuario.Rows[row].Cells[1].Value.ToString();
                    TBPassword.Text = tabla.Rows[0][0].ToString();
                    CBAdmin.Text = DTGVUsuario.Rows[row].Cells[2].Value.ToString();
                    encontrar = true;
                }
                row += 1;
            }
            //Si no se encuentra se le avisa al usuario de que ese indice ingresado no existe
            if(encontrar == false)
            {
                MessageBox.Show("El indice no existe", "INFORMATIVO");
            }
            //Se habilitan botones para continuar con el proceso de modificacion o eliminación
            else
            {
                BTNEliminar.Enabled = true;
                BTNActualizar.Enabled = true;
                BTNAgregar.Enabled = false;
                BTNModificar.Enabled = false;
            }
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            //Se emplea un boton que permita confirmar los cambios a un Usuario ya existente
            DialogResult confirmar = MessageBox.Show("¿Seguro que desea modificar este usuario?", "MODIFICAR", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (confirmar == DialogResult.Yes)
            {
                //Se realiza una conexion con la base de datos para ingresar el comando sql que efectuara los cambios
                SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
                conexion.Open();
                //Se crea un entero para convertir la informacion de la columna administrador al lenguaje sql
                int admin = 0;
                if (CBAdmin.Text == "Si")
                {
                    admin = 1;
                }
                //Usamos la variable local decision para saber en que fila se efectuaran los cambios 
                SqlCommand modificar = new SqlCommand(string.Format("update Usuario set Usuario = '{0}',Contraseña = '{1}', Administrador = {2} where Indice = {3}", TBUser.Text.ToUpper(), TBPassword.Text.ToUpper(), admin, int.Parse(decision)), conexion);
                modificar.ExecuteNonQuery();
                conexion.Close();
                //se reinicia la variable global y el formulario, para una nueva busqueda
                decision = "0";
                TBUser.Clear();
                TBPassword.Clear();
                CBAdmin.ResetText();
                BTNEliminar.Enabled = false;
                BTNActualizar.Enabled = false;
                BTNAgregar.Enabled = true;
                BTNModificar.Enabled = true;
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            //Se emplea una conexion con la base de datos para eliminar un usuario en especifico
            DialogResult confirmar = MessageBox.Show("¿Seguro que desea eliminar este Usuario?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmar == DialogResult.Yes)
            {
                //Se restringe la eliminacion del usuario admin que será el encargado de administrar los usuarios
                SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
                conexion.Open();
                if (int.Parse(decision) == 1)
                {
                    MessageBox.Show("El Usuario que desea eliminar, es un usuario del sistema y no se puede eliminar");
                }
                else
                {
                    //Se emplea el comando sql para eliminar una fila en especifico
                    SqlCommand eliminar = new SqlCommand(string.Format("delete from Usuario where Indice = {0}", int.Parse(decision)), conexion);
                    eliminar.ExecuteNonQuery();
                    //Luego se elimina del datagridview
                    DTGVUsuario.Rows.RemoveAt(int.Parse(decision) - 1);
                    int aumento = 0;
                    //Se emplea un entero que muestre el lugar del salto de indice de la nueva tabla
                    for (int row = 0; row < DTGVUsuario.Rows.Count; row++)
                    {
                        //Se usa un Comando sql que me modifique la columna indice
                        SqlCommand indice;
                        //Se condiciona el el paso del ciclo for de tal forma que cuando este en la posicion en donde da
                        //el salto de linea, este ingrese para reordenar el indice de la tabla
                        if (row + 1 >= int.Parse(decision))
                        {
                            //Se ejecuta el comando sql que altera la informacion de la columna Indice y lo ordena
                            //numericamente de forma continua
                            aumento += 1;
                            indice = new SqlCommand(string.Format("update Usuario set Indice = {0} where Indice = {1}", row + 1, int.Parse(decision) + aumento), conexion);
                        }
                        else
                        {
                            //Solo ingrese el indice que ya venia teniendo
                            indice = new SqlCommand(string.Format("update Usuario set Indice = {0} where Indice = {1}", row + 1, row + 1), conexion);
                        }
                        //Se ejecuta el comando y se modifica el datagridview en el indice
                        indice.ExecuteNonQuery();
                        DTGVUsuario.Rows[row].Cells[0].Value = row + 1;
                    }
                }
                conexion.Close();
                //Se reinicia la variable global y el formulario
                decision = "0";
                TBUser.Clear();
                TBPassword.Clear();
                CBAdmin.ResetText();
                BTNEliminar.Enabled = false;
                BTNActualizar.Enabled = false;
                BTNAgregar.Enabled = true;
                BTNModificar.Enabled = true;
            }
        }
    }
}
