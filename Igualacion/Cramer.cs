using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igualacion
{
    public class Cramer
    {
        /// <summary>
        /// Returns an array of floats being the first float the value for X and
        /// the second one the value for Y.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="z1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="z2"></param>
        /// <returns>float[2]</returns>
        public static double[] Resolucion2x2(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double D = DeterminanteDeCoeficientes2x2(x1, y1, x2, y2);
            double Dx = DeterminanteX2x2(z1, y1, z2, y2);
            double Dy = DeterminanteY2x2(x1, z1, x2, z2);

            double[] resultado = new double[2];

            resultado[0] = Dx / D;
            resultado[1] = Dy / D;

            return resultado;
        }

        private static double DeterminanteDeCoeficientes2x2(int x1, int y1, int x2, int y2)
        {
            int izq = x1 * y2;
            int der = x2 * y1;
            double D = izq - der;
            return D;
        }
        private static double DeterminanteX2x2(int z1, int y1, int z2, int y2)
        {
            int izq = z1 * y2;
            int der = z2 * y1;
            double Dx = izq - der;
            return Dx;
        }
        private static double DeterminanteY2x2(int x1, int z1, int x2, int z2)
        {
            int izq = x1 * z2;
            int der = x2 * z1;
            double Dy = izq - der;
            return Dy;
        }


    }
}
