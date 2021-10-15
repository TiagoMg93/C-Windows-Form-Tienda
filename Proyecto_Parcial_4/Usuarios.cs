using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Parcial_4
{
    public partial class FMRUsuarios : Form
    {
        //[ind]:Indice
        int n = 0, ind = 0;//para que me enumere la columna indice
        public FMRUsuarios()
        {
            InitializeComponent();
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
           
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {

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
