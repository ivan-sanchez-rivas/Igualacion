using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igualacion
{
    //ahora si ya funciona :D se que esta algo reboltojo, pero ya lo comentare mas detalladamente
    public class Sustitucion
    {
        public static double[] Sustitucion2x2(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double[] resultado = new double[2];
            //pasar a X del otro lado para despejar a y
            x1 = x1 * -1;

            double tempX = x1;
            double tempY = y1;
            double tempZ = z1;

            double resultadoX;
            double resultadoY;

            //las operaciones que se hacen para dejar a x sola
            z1 = z1 * y2;//Importa el resultado de Y y lo multiplica por la equacion
            x1 = x1 * y2;
            x2 = x2 * y1;
            z2 = z2 * y1;

            x1 = x1 + x2;
            z1 = (z1 * -1) + z2;
            if (x1 == 0)
                x1 = 0;
            try
            {
                resultadoX = z1 / x1;

                //ahora a substituir de vuelta
                tempX = tempX * resultadoX;
                tempZ = tempZ + tempX;
                resultadoY = tempZ / tempY;

                resultado[0] = resultadoX;
                resultado[1] = resultadoY;
            }
            catch { }
            return resultado;
        }
    }
}
