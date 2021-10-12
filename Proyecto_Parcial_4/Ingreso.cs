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
    public partial class FMRIngreso : Form
    {
        public FMRIngreso()
        {
            InitializeComponent();
        }

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
            
        }

        private void BTNEntrar_Click(object sender, EventArgs e)
        {
            //[f_ven]:Formulario de venta
            FRMVenta f_ven = new FRMVenta(true);
            f_ven.Show();
            this.Hide();
        }
    }
}
