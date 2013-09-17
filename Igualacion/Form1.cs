using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igualacion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            
            try
            {
                int a, b, c, a1, b1, c1;
                double[] resultado = new double[2];

                a = Convert.ToInt32(txt_a.Text);
                b = Convert.ToInt32(txt_b.Text);
                c = Convert.ToInt32(txt_c.Text);

                a1 = Convert.ToInt32(txt_a1.Text);
                b1 = Convert.ToInt32(txt_b1.Text);
                c1 = Convert.ToInt32(txt_c1.Text);


                if (cmbBox_Metodo.SelectedIndex == 0)
                {
                    Igualacion igualacion = new Igualacion(a, b, c, a1, b1, c1);
                    igualacion.Multiplicacion();
                    resultado[0] = igualacion.EncontrarX();
                    resultado[1] = igualacion.SubstitucionY();
                }
                else if (cmbBox_Metodo.SelectedIndex == 1)
                {

                    resultado = Cramer.Resolucion2x2(a, b, c, a1, b1, c1);
                }
                else
                {
                    ////MANNY's CODE HERE////
                }

                lbl_resultadoX.Text = string.Format("{0:N4}", resultado[0]);
                lbl_resultadoY.Text = string.Format("{0:N4}", resultado[1]);
            }
            catch
            {
                MessageBox.Show("Hubo un error al momento de capturar los datos");
            }

        }


    }
}
