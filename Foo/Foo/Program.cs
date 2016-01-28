using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            // 1 2 
            // 1 2 3

            int n = 8;
            S1(n);
            S1V2(n);
            S1V2_2(n);

            // 1
            // 2 2
            // 3 3 3 

            S2V2_2(n);


            int[,] m = { {1, 2, 6, -6}, 
                         {5, 7, -9, 0}, 
                         {5, 3, 7, -2}, 
                         {3, 7, 0, -2} };

            // suma elementelor de pe diagonala principala
            // suma elementelor de pe diagonala secundara.
            // suma elementelor pozitive de sub diagonala principala
            // rearanjarea liniilor matricii in ordine crescatoare dupa suma elementelor de pe linie

            Console.WriteLine("Suma elementelor de pe diagonala principala este: {0}", SumaDiagP(m));
            Console.WriteLine("Suma elementelor de pe diagonala principala este: {0}", SumaDiagS(m));
            Console.WriteLine("Suma elementelor de sub diagonala principala este: {0}", SumaSubDiagP(m));
            Console.WriteLine("Suma elementelor de deasupra diagonalei prinicale este: {0}", SubDeasupraDiagP(m));
            Spirala(m);
        }

        private static void Spirala(int[,] m)
        {
            int i1 = 0;
            int i2 = m.GetLength(0) - 1;
            int j1 = 0;
            int j2 = m.GetLength(1) - 1;

            int total = m.GetLength(0) * m.GetLength(1);
            int contor = 0;
            while (contor < total)
            {
                for (int j = j1; j <= j2; j++)
                {
                    Console.Write("{0} ", m[i1, j]);
                    contor++;
                }
                i1++;

                if (contor == total)
                {
                    break;
                }

                for (int i = i1; i <= j2; i++)
                {
                    Console.Write("{0} ", m[i, j2]);
                    contor++;
                }
                j2--;

                if (contor == total)
                {
                    break;
                }

                for (int j = j2; j >= j1; j--)
                {
                    Console.Write("{0} ", m[i2, j]);
                    contor++;
                }
                i2--;

                if (contor == total)
                {
                    break;
                }

                for (int i = i2; i >= i1; i--)
                {
                    Console.Write("{0} ", m[i, j1]);
                    contor++;
                }
                j1++;
            }
        }

        private static int SubDeasupraDiagP(int[,] m)
        {
            int suma = 0;

            for (int i = 0; i < m.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < m.GetLength(1); j++)
                {
                    suma += m[i, j];
                }
            }

            return suma;
        }

        private static int SumaSubDiagP(int[,] m)
        {
            int suma = 0;
            for (int i = 1; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    suma += m[i, j];
                }
            }

            return suma;
        }

        private static int SumaDiagS(int[,] m)
        {
            int suma = 0;
            int j;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                // i + j = n - 1;
                j = m.GetLength(0) - 1 - i;
                suma += m[i, j];
            }

            return suma;
        }

        private static int SumaDiagP(int[,] m)
        {
            int suma = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                suma = suma + m[i, i];
            }

            return suma;
        }

        private static void S2V2_2(int n)
        {
            int i = 1, j = 1;
            int contor = 0;
            while (contor < n)
            {
                Console.Write("{0} ", i);
                j++; contor++;
                if (j > i)
                {
                    i++;
                    j = 1;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private static void S1V2_2(int n)
        {
            int i = 1, j = 1;
            int contor = 0;
            while (contor < n)
            {
                Console.Write("{0} ", j);
                j++; contor++;
                if (j > i)
                {
                    i++;
                    j = 1;
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        private static void S1V2(int n)
        {
            int contor = 0;
            for (int i = 1; contor < n; i++)
            {
                for (int j = 1; j <= i && contor < n; j++)
                {
                    Console.Write("{0} ", j);
                    contor++;
                }
                Console.WriteLine();
            }
        }

        private static void S1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
        }
    }
}
