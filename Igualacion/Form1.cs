using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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
                int a;
                int b;
                int c;
                int a1;
                int b1;
                int c1;
                double[] resultado = new double[2];
                ;
                

                #region Conversion Numerica de TextBoxes
                if (txt_a.Text == "-")
                {
                    a = -1;
                }
                else
                {
                    a = Convert.ToInt32(txt_a.Text);

                }

                if (txt_b.Text == "-")
                {
                    b = -1;
                }
                else
                {
                    b = Convert.ToInt32(txt_b.Text);

                }

                if (txt_c.Text == "-")
                {
                    c = -1;
                }
                else
                {
                    c = Convert.ToInt32(txt_c.Text);

                }

                if (txt_a1.Text == "-")
                {
                    a1 = -1;
                }
                else
                {
                    a1 = Convert.ToInt32(txt_a1.Text);

                }

                if (txt_b1.Text == "-")
                {
                    b1 = -1;
                }
                else
                {
                    b1 = Convert.ToInt32(txt_b1.Text);

                }

                if (txt_c1.Text == "-")
                {
                    c1 = -1;
                }
                else
                {
                    c1 = Convert.ToInt32(txt_c1.Text);

                }
#endregion


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
                    resultado = Sustitucion.Sustitucion2x2(a, b, c, a1, b1, c1);
                }

                lbl_resultadoX.Text = string.Format("{0:N4}", resultado[0]);
                lbl_resultadoY.Text = string.Format("{0:N4}", resultado[1]);
            }
            catch
            {
                MessageBox.Show("Hubo un error al momento de capturar los datos");
            }

        }

        private void btn_CalcularRandom_Click(object sender, EventArgs e)
        {

            double[] resultadoRan = new double[122];
            Random ran = new Random();
            int a;
            int b;
            int c;
            int a1;
            int b1;
            int c1;      
            double media;
            double SumaDiferenciaCuadrados;
            double desvest;
            double z = 1.96;
            double intervaloConfianzaMax;
            double intervaloConfianzaMin;
            if (cmbBox_Metodo.SelectedIndex == 0)
            {
                for (int i = 0; i <= 120; i+=2)
                {
                    a = ran.Next(1, 100);
                    b = ran.Next(1, 100);
                    c = ran.Next(1, 100);
                    a1 = ran.Next(1, 100);
                    b1 = ran.Next(1, 100);
                    c1 = ran.Next(1, 100);

                    Igualacion igualacion = new Igualacion(a, b, c, a1, b1, c1);
                    igualacion.Multiplicacion();
                    resultadoRan[i] = igualacion.EncontrarX();
                    resultadoRan[i+1] = igualacion.SubstitucionY();
                }
                media = resultadoRan.Average();
                SumaDiferenciaCuadrados = resultadoRan.Select(val => (val - media) * (val - media)).Sum();
                desvest = Math.Sqrt(SumaDiferenciaCuadrados / resultadoRan.Length);
                intervaloConfianzaMin = (media - z) * desvest;
                intervaloConfianzaMax = (media + z) * desvest;
                //El intervalo se encuentra en esa parte con una confianza de 95%
            }
            //else if (cmbBox_Metodo.SelectedIndex == 1)
            //{
            //        resultadoRan = Cramer.Resolucion2x2(a, b, c, a1, b1, c1); 
            //    media = resultadoRan.Average();

            //}
            //else
            //{
            //    resultado = Sustitucion.Sustitucion2x2(a, b, c, a1, b1, c1);
            //}

       
        }


    }
}
