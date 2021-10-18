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
        /*[mod]=modificar , [fila_temp]:fila temporal 
        se pone las variables en el [public partial class] para que se pueda instanciar en cualquier lugar del código.*/

        int n=0, fila_temp=0;
        string mod = "";

        public FMRDescuentos()
        {
            InitializeComponent();
        }

        private void BTNCerrar_Click(object sender, EventArgs e)
        {            
            /*hace que me cierre este formulario sin necesidad de crear un objeto para este formulario.*/
            this.Close();
        }

        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            /*Me agrega una linea al datagrid*/
            n=DTGVDescuento.Rows.Add();

            /*Agrega al data grid lo que copio o eligio el usuario al combo box o text box*/
            DTGVDescuento.Rows[n].Cells[1].Value = CBArticulo.Text;
            DTGVDescuento.Rows[n].Cells[2].Value = TBDescuento.Text;
            
            //este es para agregar el código al data grid
            //DTGVDescuento.Rows[n].Cells[0].Value = Convert.ToString();

            /*Es para que yo no tenga que borrar elementos del combo box y el text box al presionar el boton agregar*/
            CBArticulo.Text = "";
            TBDescuento.Text = "";
        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {
            /*Me va a salir una ventana en la cual me pide un código que yo desee modificar, y me la va a guardar 
            en la varible mod*/
            mod = Convert.ToString(Interaction.InputBox("Escriba el código del articulo que quiere modificarle el descuento"));
            
            /*Me va a recorrer el total del los renglones que tenga el data grid, y me va a estar preguntando si lo que
             copio el usuario es igual a lo que tengo en la columna 0, para despues copiarme el resultado en el combo box
             y el text box*/
            for(int fila=0;fila<DTGVDescuento.Rows.Count;fila++)
            {
                if(mod==Convert.ToString(DTGVDescuento.Rows[fila].Cells[0].Value))
                {
                    CBArticulo.Text = Convert.ToString(DTGVDescuento.Rows[fila].Cells[1].Value);
                    TBDescuento.Text = Convert.ToString(DTGVDescuento.Rows[fila].Cells[2].Value);
                    /*Se necesita [fila_temp] para poder guardar el número de fila que se este modificando, esto va hacer
                     de gran ayuda´, para cuando le demos al botón actualizar*/
                    fila_temp = fila;
                }
            }
            /*Hace que el botón actualizar se pueda utilizar, y se desactivan el botón agregar y el combo box del articulo
             para que el usuario no lo pueda modificar*/
            BTNActualizar.Enabled = true;
            BTNAgregar.Enabled = false;
            CBArticulo.Enabled = false;
        }

        private void FMRDescuentos_Load(object sender, EventArgs e)
        {
            /*Me activa lo que es el combo box de articulo, y el text box de descuento*/
            CBArticulo.Enabled = true;
            TBDescuento.Enabled = true;
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            /*Me actualiza los datos de un renglon especifico, es por eso que pusimos la variable [fila_temp] como global
             en el botón modificar*/
            DTGVDescuento.Rows[fila_temp].Cells[1].Value = CBArticulo.Text;
            DTGVDescuento.Rows[fila_temp].Cells[2].Value = TBDescuento.Text;

            /*Se vuelve a  activar el botón agregar y el como box del articulo, y se me desactiva el botón actualizar*/
            BTNAgregar.Enabled = true;
            CBArticulo.Enabled = true;
            BTNActualizar.Enabled = false;

            //Me deja limpio los textbox y el combo box para que yo no tenga la necesidad de borrarlos.
            TBDescuento.Text = "";
            CBArticulo.Text = "";
        }
    }
}
