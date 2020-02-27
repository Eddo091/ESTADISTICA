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
    public partial class Estadistica : Form
    {
        estadsitica objEstadistica = new estadsitica();
        public Estadistica()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            try
            { //split => divide una cadena en base a un delimitador (patron) y devuelve una matriz
                lblrespuesta.Text = "X=" + objEstadistica.media(txtserie.Text.Split(','));
            }
            catch (Exception error) {
                MessageBox.Show ("Numero no identificado"+ error.Message, "Media Aritmetica",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCalcularEstandar_Click(object sender, EventArgs e)
        {
            try { lblrespuesta.Text = "Estandar=" + objEstadistica.estandar(txtserie.Text.Split(',')); } catch (Exception error)
            {
                MessageBox.Show("Numero no identificado" + error.Message, "Media Estandar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCalcularTpica_Click(object sender, EventArgs e)
        {
            try
            {
                lblrespuesta.Text = "Tipica=" + objEstadistica.tipica(txtserie.Text.Split(','));
            }
            catch(Exception error) {
                MessageBox.Show("Numero no identificado" + error.Message, "Tipica",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void grdEstadistica_KeyUp(object sender, KeyEventArgs e)
        {
            try{
                int nfilas = grdEstadistica.Rows.Count - 1,
                    sumaf1 = 0,
                    sumaxixfi = 0;
                double sumax2ixfi = 0;
                  // bool Moda;
                int count = 0;
                DataGridViewRow fila;

                for (int i = 0; i < nfilas; i++){
                    fila = grdEstadistica.Rows[i];
                    int x1 = int.Parse(fila.Cells["x1"].Value.ToString()),
                        f1 = int.Parse(fila.Cells["f1"].Value.ToString());
                    sumaf1 += f1;
                    sumaxixfi += x1 * f1;
                    sumax2ixfi += Math.Pow(x1, 2) * f1;
                    
                    fila.Cells["fi"].Value = sumaf1.ToString();
                    fila.Cells["xixfi"].Value = (x1*f1).ToString();
                    fila.Cells["x2ixfi"].Value = ( Math.Pow(x1,2) * f1).ToString();
                  
                    //Moda
                    
                    if (x1 == f1)
                    {
                        count++;
                        if (x1 != 0)
                        {
                            lblModa.Text = x1 + " Se repite "+ count;

                            

                        }
                    }

                }
                 

                lbltotalf1.Text = sumaf1.ToString();
                lbltotalxixfi.Text = sumaxixfi.ToString();
                lbltotalx2ixfi.Text = sumax2ixfi.ToString();
                lblModa.Text = count.ToString();

                double media = sumaxixfi / sumaf1,
                    standar = sumax2ixfi / sumaf1 - Math.Pow(media,2),
                    tipica = Math.Sqrt(standar);

               
              
                lblmedia.Text = media.ToString();
                lblestandar.Text = standar.ToString();
                lbltipica.Text = tipica.ToString();
                lblModa.Text = " Se repite " + count;
            }
            catch(Exception error) {
                MessageBox.Show("Numero no identificado" + error.Message, "Estadistica",
 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grdEstadistica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
