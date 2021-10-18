using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Parcial_4
{
    public partial class FMRUsuarios : Form
    {
        /*[ind]:Indice,[ind_esc]:Indice escogido, [fila_act]: fila escogida
         Se dejan las variables en ´public partial class para que puedan ser utilizadas en todo el fomulario*/

        int n = 0, ind = 0, fila_act=0;//[ind]para que me enumere la columna indice
        string ind_esc = "";
        public FMRUsuarios()
        {
            InitializeComponent();
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            /*Me crea un objeto del formulario ventas y usuarios, para que puedan ser instanciados, el formulario venta se me
             va a abrir y el formulario usuario se me va a cerrar*/
            FRMVenta f_vent = new FRMVenta(true);
            f_vent.Show();
            FMRUsuarios f_usu = new FMRUsuarios();
            f_usu.Close();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            /*Me va a activar el botón actualizar y se me va a desactivar el botón agregar*/
            BTNAgregar.Enabled = false;
            BTNActualizar.Enabled = true;

            /*Me va a abrir una ventana para que el usuario ingrese el indice que quiere modificar y me lo va guardar en la 
             variable [ind_esc]*/
            ind_esc = Convert.ToString(Interaction.InputBox("Escriba el indice que quiere modificar"));

            /*Me va a recorrer todos los renglones que tenga mi data grid, y me va a preguntar si el indice que ingrese
             es igual los que tenga en el data grid*/
            for(int fila=0; fila<DTGVUsuario.Rows.Count;fila++)
            {
                if(ind_esc==Convert.ToString(DTGVUsuario.Rows[fila].Cells[0].Value))
                {
                    /*Me va a poner la infromacion del indice que habiamos digitado en los textbox y combobox */
                    txtb_usu.Text = Convert.ToString(DTGVUsuario.Rows[fila].Cells[1].Value);
                    CBAdmin.Text = Convert.ToString(DTGVUsuario.Rows[fila].Cells[2].Value);
                    TBPassword.Text = Convert.ToString(DTGVUsuario.Rows[fila].Cells[3].Value);
                    
                    /*[fila_act]: me va a servir para que no se me pierda de la fila en la que me encunetro*/
                    fila_act = fila;

                }
            }
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            /*agrega los datos actualizados al datagrid*/
            DTGVUsuario.Rows[fila_act].Cells[1].Value = txtb_usu.Text;
            DTGVUsuario.Rows[fila_act].Cells[2].Value = CBAdmin.Text;
            DTGVUsuario.Rows[fila_act].Cells[3].Value = TBPassword.Text;

            /*Me activa el botón agregar y me desactiva el botón actualizar*/
            BTNActualizar.Enabled = false;
            BTNAgregar.Enabled = true;
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            /*se va estar acumulando de uno en uno la variable [ind]*/
            ind++;
            /*Me va agregar un renglon al data grid*/
            n=DTGVUsuario.Rows.Add();
            /*Se van a guardar los datos que ingrese en el text box y combo box al data grid*/
            DTGVUsuario.Rows[n].Cells[0].Value = Convert.ToString(ind);
            DTGVUsuario.Rows[n].Cells[1].Value = txtb_usu.Text;
            DTGVUsuario.Rows[n].Cells[2].Value = CBAdmin.Text;
            DTGVUsuario.Rows[n].Cells[3].Value = TBPassword.Text;

            /*Se van a limpiar los textbox y combo box, para que no tenga que borrarlos manualmente*/
            txtb_usu.Text = "";
            TBPassword.Text = "";
            CBAdmin.Text = "";

        }
    }
}
