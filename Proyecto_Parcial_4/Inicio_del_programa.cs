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
    public partial class Inicio_del_programa : MaterialSkin.Controls.MaterialForm
    {
        public Inicio_del_programa()
        {
            InitializeComponent();
        }

        private void Inicio_del_programa_Load(object sender, EventArgs e)
        {
            lb_info.Visible = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            lb_info.Visible = true;
                if(progressBar1.Value==100)
                {                   
                    timer1.Stop();                    
                    FMRIngreso f_ing = new FMRIngreso();
                    f_ing.Show();
                    this.Hide();
                }
            lb_info.Text = $"{progressBar1.Value}%";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
