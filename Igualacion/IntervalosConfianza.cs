using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igualacion
{
    class IntervalosConfianza
    {
        static private int  NumeroRondaMax = 30;
        static private int NumeroCoeficientes = 120000;

        public static int[] GeneraCoeficientes()
        {
            int[] coeficientes = new int[NumeroCoeficientes];
            int a, b, c, a1, b1, c1;
            Random ran = new Random();

            for (int i = 0; i < NumeroCoeficientes / 6; i++)
            {

                a = (i * 6);
                b = (i * 6) + 1;
                c = (i * 6) + 2;
                a1 = (i * 6) + 3;
                b1 = (i * 6) + 4;
                c1 = (i * 6) + 5;

                coeficientes[a] = ran.Next(1, 100);
                coeficientes[b] = ran.Next(1, 100);
                coeficientes[c] = ran.Next(0, 100);
                coeficientes[a1] = ran.Next(1, 100);
                coeficientes[b1] = ran.Next(1, 100);
                coeficientes[c1] = ran.Next(0, 100);

            }

            return coeficientes;
        }
       
        public static long[] CalcularTiempoIgualacion(int[] coeficientes)
        {
            Stopwatch sw = new Stopwatch();
            long[] tiempo = new long[NumeroRondaMax];
            double media = 0;

            do
            {
                for (int NumeroRonda = 0; NumeroRonda < NumeroRondaMax; NumeroRonda++)
                {
                    sw.Restart();
                    for (int i = 0; i < (NumeroCoeficientes/ NumeroRondaMax) * NumeroRonda; i++)
                    {
                        //int a = (i * 6);
                        //int b = (i * 6) + 1;
                        //int c = (i * 6) + 2;
                        //int a1 = (i * 6) + 3;
                        //int b1 = (i * 6) + 4;
                        //int c1 = (i * 6) + 5;

                        int a = i;
                        int b = i++;
                        int c = i++;
                        int a1 = i++;
                        int b1 = i++;
                        int c1 = i++;

                        Igualacion igualacion = new Igualacion(coeficientes[a], coeficientes[b], coeficientes[c],
                            coeficientes[a1], coeficientes[b1], coeficientes[c1]);
                        igualacion.Multiplicacion();
                        igualacion.EncontrarX();
                        igualacion.SubstitucionY();

                    }
                    sw.Stop();
                    tiempo[NumeroRonda] = sw.ElapsedMilliseconds;
                }
                media = tiempo.Average();

            } while (double.IsNegativeInfinity(media) || double.IsPositiveInfinity(media) || double.IsNaN(media));

            return tiempo;
        }

        public static long[] CalcularTiempoCramer(int[] coeficientes)
        {
            Stopwatch sw = new Stopwatch();
            long[] tiempo = new long[NumeroRondaMax];
            double media = 0;

            do
            {
                for (int NumeroRonda = 0; NumeroRonda < NumeroRondaMax; NumeroRonda++)
                {
                    sw.Restart();
                    for (int i = 0; i < (NumeroCoeficientes / NumeroRondaMax) * NumeroRonda; i++)
                    {

                        int a = i;
                        int b = i++;
                        int c = i++;
                        int a1 = i++;
                        int b1 = i++;
                        int c1 = i++;

                        Cramer.Resolucion2x2(coeficientes[a], coeficientes[b], coeficientes[c],
                            coeficientes[a1], coeficientes[b1], coeficientes[c1]);
                    }
                    sw.Stop();
                    tiempo[NumeroRonda] = sw.ElapsedMilliseconds;
                }
                media = tiempo.Average();

            } while (double.IsNegativeInfinity(media) || double.IsPositiveInfinity(media) || double.IsNaN(media));

            return tiempo;
        }

        public static long[] CalcularTiempoSustitucion(int[] coeficientes)
        {
            Stopwatch sw = new Stopwatch();
            long[] tiempo = new long[NumeroRondaMax];
            double media = 0;

            do
            {
                for (int NumeroRonda = 0; NumeroRonda < NumeroRondaMax; NumeroRonda++)
                {
                    sw.Restart();
                    for (int i = 0; i < (NumeroCoeficientes / NumeroRondaMax) * NumeroRonda; i++)
                    {
                        int a = i;
                        int b = i++;
                        int c = i++;
                        int a1 = i++;
                        int b1 = i++;
                        int c1 = i++;

                        Sustitucion.Sustitucion2x2(coeficientes[a], coeficientes[b], coeficientes[c],
                            coeficientes[a1], coeficientes[b1], coeficientes[c1]);
                    }
                    sw.Stop();
                    tiempo[NumeroRonda] = sw.ElapsedMilliseconds;
                }
                media = tiempo.Average();

            } while (double.IsNegativeInfinity(media) || double.IsPositiveInfinity(media) || double.IsNaN(media));

            return tiempo;
        }
            
        /// <summary>
        ///El intervalo se encuentra en esa parte con una confianza de 95% 
        /// </summary>
        /// <param name="tiempo">Conjunto de Muestras</param>
        /// <returns>Un array de doubles en donde el primer elemento es el Intervalo minimo 
        /// y el segundo el maximo</returns>
        public static double[] CalcularIntervalosConfianza(long[] tiempo)
        {
            double media = tiempo.Average();
            double z = 1.96;
            double SumaDiferenciaCuadrados, desvest;
            double[] IntervalosConfianza = new double[2];

            SumaDiferenciaCuadrados = tiempo.Select(val => (val - media) * (val - media)).Sum();
            desvest = Math.Sqrt(SumaDiferenciaCuadrados / tiempo.Length);

            IntervalosConfianza[0] = media - z * desvest/(Math.Sqrt(tiempo.Length));
            IntervalosConfianza[1] = media + z * desvest/(Math.Sqrt(tiempo.Length));

            return IntervalosConfianza;

        }

    }
}
