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
    }
}
