using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class Form2 : Form
    {
        Estadistica Estadistica = new Estadistica();
        ConversorUnidades Conversor = new ConversorUnidades();
        public Form2()
        {
            InitializeComponent();
            
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversor.Hide();

            Estadistica.MdiParent=this;
            Estadistica.Show();
           
            lblFormularioActivo.Text = Estadistica.Text;
        }

        private void conversoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Estadistica.Hide();
            Conversor.MdiParent = this;

            Conversor.Show();
           
            lblFormularioActivo.Text = Conversor.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void lblFormularioActivo_Click(object sender, EventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblStatusFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();   
        }
    }

   
}
