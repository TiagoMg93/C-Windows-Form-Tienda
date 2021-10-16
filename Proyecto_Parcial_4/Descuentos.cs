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
    public partial class FMRDescuentos : Form
    {
        //[mod]=modificar , [fila_temp]:fila temporal 
        int n=0, fila_temp=0, a=0;
        string mod = "";

        public FMRDescuentos()
        {
            InitializeComponent();
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            a++;
            n=DTGVDescuento.Rows.Add();

            DTGVDescuento.Rows[n].Cells[1].Value = CBArticulo.Text;
            DTGVDescuento.Rows[n].Cells[2].Value = TBDescuento.Text;
            DTGVDescuento.Rows[n].Cells[0].Value = Convert.ToString(a);

            CBArticulo.Text = "";
            TBDescuento.Text = "";
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            mod = Convert.ToString(Interaction.InputBox("Escriba el código del articulo que quiere modificarle el descuento"));
            for(int fila=0;fila<DTGVDescuento.Rows.Count;fila++)
            {
                if(mod==Convert.ToString(DTGVDescuento.Rows[fila].Cells[0].Value))
                {
                    CBArticulo.Text = Convert.ToString(DTGVDescuento.Rows[fila].Cells[1].Value);
                    TBDescuento.Text = Convert.ToString(DTGVDescuento.Rows[fila].Cells[2].Value);
                    fila_temp = fila;
                }
            }
            BTNActualizar.Enabled = true;
            BTNAgregar.Enabled = false;
            CBArticulo.Enabled = false;
        }

        private void FMRDescuentos_Load(object sender, EventArgs e)
        {
            CBArticulo.Enabled = true;
            TBDescuento.Enabled = true;
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            DTGVDescuento.Rows[fila_temp].Cells[1].Value = CBArticulo.Text;
            DTGVDescuento.Rows[fila_temp].Cells[2].Value = TBDescuento.Text;

            BTNAgregar.Enabled = true;
            CBArticulo.Enabled = true;
            BTNActualizar.Enabled = false;

            TBDescuento.Text = "";
            CBArticulo.Text = "";
        }
    }
}
