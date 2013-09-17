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
            int a, b, c, a1, b1, c1;
            a = Convert.ToInt32(txt_a.Text);
            b = Convert.ToInt32(txt_b.Text);
            c = Convert.ToInt32(txt_c.Text);

            a1 = Convert.ToInt32(txt_a1.Text);
            b1 = Convert.ToInt32(txt_b1.Text);
            c1 = Convert.ToInt32(txt_c1.Text);

            Igualacion igualacion = new Igualacion(a, b, c, a1, b1, c1);
            igualacion.Multiplicacion();
            lbl_resultadoX.Text  = Convert.ToString(igualacion.EncontrarX());
            lbl_resultadoY.Text = Convert.ToString(igualacion.SubstitucionY());

            
        }

        private void btn_Cramer_Click(object sender, EventArgs e)
        {
            int x1, y1, z1, x2, y2, z2;
            x1 = Convert.ToInt32(txt_a.Text);
            y1 = Convert.ToInt32(txt_b.Text);
            z1 = Convert.ToInt32(txt_c.Text);

            x2 = Convert.ToInt32(txt_a1.Text);
            y2 = Convert.ToInt32(txt_b1.Text);
            z2 = Convert.ToInt32(txt_c1.Text);

            float[] resultado = Cramer.Resolucion2x2(x1, y1, z1, x2, y2, z2);

            MessageBox.Show(String.Format("X = {0}, Y = {1}", resultado[0], resultado[1]));
        }
    }
}
