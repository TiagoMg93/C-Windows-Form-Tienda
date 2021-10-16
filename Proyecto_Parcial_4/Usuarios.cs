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
        //[ind]:Indice,[ind_esc]:Indice escogido
        int n = 0, ind = 0, fila_act=0;//[ind]para que me enumere la columna indice
        string ind_esc = "";
        public FMRUsuarios()
        {
            InitializeComponent();
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            FRMVenta f_vent = new FRMVenta(true);
            f_vent.Show();
            FMRUsuarios f_usu = new FMRUsuarios();
            f_usu.Close();
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            

            BTNAgregar.Enabled = false;
            BTNActualizar.Enabled = true;

            ind_esc = Convert.ToString(Interaction.InputBox("Escriba el indice que quiere modificar"));
            for(int fila=0; fila<DTGVUsuario.Rows.Count;fila++)
            {
                if(ind_esc==Convert.ToString(DTGVUsuario.Rows[fila].Cells[0].Value))
                {
                    //me llena los text box y combo box de la busquedad 
                    txtb_usu.Text = Convert.ToString(DTGVUsuario.Rows[fila].Cells[1].Value);
                    CBAdmin.Text = Convert.ToString(DTGVUsuario.Rows[fila].Cells[2].Value);
                    TBPassword.Text = Convert.ToString(DTGVUsuario.Rows[fila].Cells[3].Value);
                    
                    fila_act = fila;//estav variable es para que pueda pasar al boton actualizar

                }
            }
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            //agrega los datos actualizados al datagrid
            DTGVUsuario.Rows[fila_act].Cells[1].Value = txtb_usu.Text;
            DTGVUsuario.Rows[fila_act].Cells[2].Value = CBAdmin.Text;
            DTGVUsuario.Rows[fila_act].Cells[3].Value = TBPassword.Text;

            BTNActualizar.Enabled = false;
            BTNAgregar.Enabled = true;
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            ind++;
            n=DTGVUsuario.Rows.Add();
            DTGVUsuario.Rows[n].Cells[0].Value = Convert.ToString(ind);
            DTGVUsuario.Rows[n].Cells[1].Value = txtb_usu.Text;
            DTGVUsuario.Rows[n].Cells[2].Value = CBAdmin.Text;
            DTGVUsuario.Rows[n].Cells[3].Value = TBPassword.Text;

            txtb_usu.Text = "";
            TBPassword.Text = "";
            CBAdmin.Text = "";

        }
    }
}
