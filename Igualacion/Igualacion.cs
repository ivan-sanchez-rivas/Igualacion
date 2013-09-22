using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Igualacion
{
    public class Igualacion
    {
        //Se declaran las variables que se van a utilizar en las dos ecuaciones.
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }


       public double a1 { get; set; }
       public double b1 { get; set; }
       public double c1 { get; set; }

       double Ecuacion1a, Ecuacion1b, Ecuacion1c;
       double Ecuacion2a, Ecuacion2b, Ecuacion2c;
       double x;
        

        //Se pasan los valores recibidos al constructor para empezar a hacer las operaciones
       public Igualacion(double A, double B, double C, double A1, double B1, double C1)
       {
           a = A;
           b = B;
           c = C;

           a1 = A1;
           b1 = B1;
           c1 = C1;
       }
        //Se realiza la multiplicacion de la segunda ecuacion de "Y" con la primera y viceversa
       public void Multiplicacion()
       {
           double ib, ib1;
           if (b < 0 && b1 < 0)
           {
               ib = -b;
               ib1 = -b1;

               Ecuacion1a = a * ib1;
               Ecuacion1b = b * ib1;
               Ecuacion1c = c * ib1;

               Ecuacion2a = a1 * ib;
               Ecuacion2b = b1 * ib;
               Ecuacion2c = c1 * ib;
           }
           else if (b > 0 && b1 < 0)
           {
               ib = b;
               ib1 = -b1;

               Ecuacion1a = a * ib1;
               Ecuacion1b = b * ib1;
               Ecuacion1c = c * ib1;

               Ecuacion2a = a1 * ib;
               Ecuacion2b = b1 * ib;
               Ecuacion2c = c1 * ib;
           }
           else if (b < 0 && b1 > 0)
           {
               ib = -b;
               ib1 = b1;

               Ecuacion1a = a * ib1;
               Ecuacion1b = b * ib1;
               Ecuacion1c = c * ib1;

               Ecuacion2a = a1 * ib;
               Ecuacion2b = b1 * ib;
               Ecuacion2c = c1 * ib;
           }
           else
           {
               ib = b;
               ib1 = b1;

               Ecuacion1a = a * -ib1;
               Ecuacion1b = b * -ib1;
               Ecuacion1c = c * -ib1;

               Ecuacion2a = a1 * ib;
               Ecuacion2b = b1 * ib;
               Ecuacion2c = c1 * ib;
           }
       }
        //Se encuentra la "X" de la primera ecuacion en la cual sumamos y despues sacamos la divison del resultado que nos dio
       public double EncontrarX()
       {
           if (Ecuacion2a > 0 && Ecuacion2b > 0)
           {
               double resultadoIzq = Ecuacion1a + Ecuacion1b + Ecuacion2a + Ecuacion2b;
               double resultadoDer = Ecuacion1c + Ecuacion2c;
               x = resultadoDer / resultadoIzq;
               return x;
           }
           else if (Ecuacion2a < 0 && Ecuacion2b < 0)
           {
               double resultadoIzq = Ecuacion1a + Ecuacion1b - Ecuacion2a - Ecuacion2b;
               double resultadoDer = Ecuacion1c + Ecuacion2c;
               x = resultadoDer / resultadoIzq;
               return x;
           }
           else if (Ecuacion2a > 0 && Ecuacion2b < 0)
           {
               double resultadoIzq = Ecuacion1a + Ecuacion2a;
               double resultadoDer = Ecuacion1c + Ecuacion2c;
               x = resultadoDer / resultadoIzq;
               return x;
           }
           else
           {
               double resultadoIzq = Ecuacion1a + Ecuacion2a - (Ecuacion1b + Ecuacion2b);
               double resultadoDer = Ecuacion1c + Ecuacion2c;
               x = resultadoDer / resultadoIzq;
               return x;
           }
 
       }
        //Se realiza lo mismo pero con la "Y"
       public double SubstitucionY()
       {
           double resultadoIzq = a * x;
           double operacion;

           if (resultadoIzq > 0)
           {
               operacion = -resultadoIzq + c;
           }
           else
           {
               operacion = resultadoIzq + c;
           }
           double resultadoY = operacion / b;
           return resultadoY;

       }

    }
}
