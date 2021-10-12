﻿using System;
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
    public partial class FRMVenta : Form
    {
        //[adm]:adminsitrador
        bool adm;//La instancio aquí para poder utilizarla en todo el formulario
        
        public FRMVenta(bool administrador)
        {
            InitializeComponent();
         //estoy recibiendo el bool del formulario anterior(administrador) aquí porque es el unico lugar que me deja instanciar.
          adm = administrador;                        
        }

        private void FRMVenta_Load(object sender, EventArgs e)
        {
            //hago una condición if para saber si es administrador para habilitar el menustrip 
           if(adm==true)
            {
                menuStrip1.Enabled = true;

            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_prov]:Formulario provedores
            FMRProveedores f_prov = new FMRProveedores();
            f_prov.Show();            
        }

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_dev]:Formulario devoluciones
            FMRDevoluciones f_dev = new FMRDevoluciones();
            f_dev.Show();                     
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_infor]:Formulario informe
            FMRInformes f_infor = new FMRInformes();
            f_infor.Show();            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_inve]:Formulario inventario
            FMRInventarios f_inve = new FMRInventarios();
            f_inve.Show();            
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_usu]:Formulario usuario 
            FMRUsuarios f_usu = new FMRUsuarios();
            f_usu.Show();            
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_des]:Formulario descuento
            FMRDescuentos f_des = new FMRDescuentos();
            f_des.Show();            
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_his]:Formulario historial
            FRMHistorial f_his = new FRMHistorial();
            f_his.Show();           
        }

        private void BTNSalir_Click(object sender, EventArgs e)//lo que hace es que me abra el formulario 
        {
            //[f_ing]:Formulario ingreso
            FMRIngreso f_ing = new FMRIngreso();
            f_ing.Show();            
        }
    }
}
