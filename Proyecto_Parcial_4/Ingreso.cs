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
    public partial class FMRIngreso : Form
    {
        public FMRIngreso()
        {
            InitializeComponent();
        }
        //variable que denota la cantidad de oportunidad que tiene el usuario para equivocarse en el ingreso de la información
        int intentos = 3;

        private void FMRIngreso_Load(object sender, EventArgs e)
        {

        }
        private void TBPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            //Mensaje de advertencia por el cierre de la app
            DialogResult decision = MessageBox.Show("¿Seguro que desea salir?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (decision == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BTNEntrar_Click(object sender, EventArgs e)
        {
            //Se crea una conexion con la base de datos en sql-server, se debe importar System.Data.SqlClient
            SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-108L2NP;Initial Catalog = Tienda;Integrated Security = True");
            conexion.Open();
            //Se adapta la tabla sql a una tabla de datos
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Usuario,Contraseña,Administrador from Usuario", conexion);
            DataTable tabla = new DataTable();
            //Se llena la tabla de datos
            dataAdapter.Fill(tabla);
            //Se crean dos variables que atrapen lo ingresado en los textBox y se convierte la cadena de texto a mayuscula
            string usuario = TBUser.Text.ToUpper(); 
            string password = TBPassword.Text.ToUpper();
            //Se crean tres vectores que contendran las columnas de nombre de usuario, contraseña y si el usuario es administrador o no
            string[] contraseñas = new string[tabla.Rows.Count];
            string[] usuarios = new string[tabla.Rows.Count];
            string[] admin = new string[tabla.Rows.Count];
            //Se emplean un ciclo for para recorrer las filas de la tabla
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                usuarios[fila] = tabla.Rows[fila]["Usuario"].ToString();
                contraseñas[fila] = tabla.Rows[fila]["Contraseña"].ToString();
                admin[fila] = tabla.Rows[fila]["Administrador"].ToString();
            }
            //Se crean dos variables booleanas una para verificar si es correcta la informacion y la otra para extraer si el
            //usuario es administrador o no
            bool administrador=false;
            bool entrar = false;
            int position = 0;
            //Se hace un ciclo while con condicionales or para que itere hasta encontrar una salida
            //en el primer caso que itere hasta que compare lo ingresado con todos los usuarios o ingrese a la app
            while(position < usuarios.Length && entrar == false)
            {
                //Se hace un condicional que compare lo ingresado en el textBox usuario con los usuarios de la base de datos
                if (usuario == usuarios[position])
                {
                    //Se hace un condicional que compare la contraseña correspondiente al nombre de usuario de la base datos
                    //con lo ingresado en el textBox de contraseña
                    if (password == contraseñas[position])
                    {
                        //Se extrae el booleano correspondiente de si esa cuenta es administrador o no
                        if(admin[position] == "1")
                        {
                            administrador = true;
                        }
                        else
                        {
                            administrador = false;
                        }
                        //se saca el programa del ciclo
                        entrar = true;
                    }
                }
                position += 1;
            }
            //Si el programa termina el ciclo sin ingresar exitosamente se muestra un mensaje y se retira un intento
            intentos -= 1;
            if (entrar != true)
            {
                string texto = "El nombre de usuario o la constraseña son incorrectos, por favor verifique tiene " + Convert.ToString(intentos) + " intento(s)";
                MessageBox.Show(texto, "ACCESO DENEGADO");
                //Se limpian los textBox para denuevo poder ingresar la información
                TBUser.ResetText();
                TBPassword.ResetText();
            }
            else
            {
                //Se crea el formulario central de la app mandandole el booleano correspondiente a las funcionalidad permitidas
                //de quien ingresa
                FRMVenta formulario = new FRMVenta(administrador);
                TBUser.ResetText();
                TBPassword.ResetText();
                formulario.Show();
                MessageBox.Show("Bienvenido " + TBUser.Text);
                TBUser.ResetText();
                TBPassword.ResetText();
                intentos = 3;
                conexion.Close();
                this.Close();
            }
            //Se hace un condicional donde podamos cerrar el programa si se supera el número de intentos
            if(intentos == 0)
            {
                MessageBox.Show("Ha excedido el número de intentos permitidos", "ERROR");
                this.Close();
                conexion.Close();
            }
        }
    }
}
