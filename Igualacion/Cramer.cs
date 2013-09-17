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
        /// <returns>float[]</returns>
        public static float[] Resolucion2x2(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            float D = DeterminanteDeCoeficientes2x2(x1, y1, x2, y2);
            float Dx = DeterminanteX2x2(z1, y1, z2, y2);
            float Dy = DeterminanteY2x2(x1, z1, x2, z2);

            float[] resultado = new float[2];

            resultado[0] = Dx / D;
            resultado[1] = Dy / D;

            return resultado;
        }

        private static float DeterminanteDeCoeficientes2x2(int x1, int y1, int x2, int y2)
        {
            int izq = x1 * y2;
            int der = x2 * y1;
            float D = izq - der;
            return D;
        }
        private static float DeterminanteX2x2(int z1, int y1, int z2, int y2)
        {
            int izq = z1 * y2;
            int der = z2 * y1;
            float Dx = izq - der;
            return Dx;
        }
        private static float DeterminanteY2x2(int x1, int z1, int x2, int z2)
        {
            int izq = x1 * z2;
            int der = x2 * z1;
            float Dy = izq - der;
            return Dy;
        }


    }
}
