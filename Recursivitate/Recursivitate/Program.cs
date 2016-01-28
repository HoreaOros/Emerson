using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivitate
{
    class Program
    {
        static void Main(string[] args)
        {
            // n! = n * (n - 1) * .... 2 * 1
            int produs = 1, n = 7;
            for (int i = 1; i <= n; i++)
            {
                produs *= i; // produs = produs * i; matrice[v[i], a[i, j]] *= ....
            }
            Console.WriteLine("{0}", produs);

            // n! = n * (n - 1)!
            // Daca n = 1 atunci n! = 1;
            int factorial = 0;
            factorial = Factorial(n);

            // Suma cifrelor unui numar;
            // SumaCifre(n) = n % 10 + SumaCifre(n / 10), daca n > 0;
            //              = 0 daca n = 0

            int numar = 12468;
            Console.WriteLine("Suma cifrelor numarului {0} este {1}", numar, SumaCifre(numar));

            // Sirul lui Fibonnaci
            // f0 = 1, f1 = 1, f(n) = f(n - 1) + f(n - 2);
            // 1, 1, 2, 3, 5, 8, 13, ...

            n = 10;
            Console.WriteLine("{0}", Fibo(n));

            // Numarul de cifre al unui numar;
            // NumarCifre(n) = 1 daca n < 10
            //               = 1 + NumarCifre(n / 10)
        }

        private static int Fibo(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }
        }

        private static int SumaCifre(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + SumaCifre(n / 10);
            }
        }

        private static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
