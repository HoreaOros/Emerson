using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3nPlus1
{
    class Program
    {
        static void Main(string[] args)
        {


            int N;


            /* N = Util.ExtractInt();
            int lungimeSecventa;
            int maximSecventa;
            lungimeSecventa = TreiNPlus1(N, out maximSecventa); */

            int a, b;

            a = Util.ExtractInt();
            b = Util.ExtractInt();

            if (a > b)
            {
                Util.Swap(ref a, ref b);
            }

            StreamWriter sw = new StreamWriter("3nplus1.txt");

            int lungimeSecventa;
            int maximSecventa;
            int lungimeMaxima = 0;
            int numar = 0;

            for (int i = a; i <= b; i++)
            {
                lungimeSecventa = TreiNPlus1(i, out maximSecventa, sw);
                if (lungimeSecventa > lungimeMaxima)
                {
                    lungimeMaxima = lungimeSecventa;
                    numar = i;
                }
            }
            sw.WriteLine("Cea mai lunga secventa contine {0} numere si se obtine pentru numarul {1}", lungimeMaxima, numar);
            sw.Close();
        }

        private static int TreiNPlus1(int n, out int maxim, StreamWriter sw)
        {
            int contor = 1;
            maxim = n;
            sw.Write("{0} ", n);
            if (n > 0)
            {
                do
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }

                    sw.Write("{0} ", n);

                    contor++;

                    if (n > maxim)
                    {
                        maxim = n;
                    }
                } while (n != 1);
                sw.WriteLine();
                sw.WriteLine("Lungimea secventei este: {0}.", contor);
                sw.WriteLine("Cel mai mare numar din secventa este: {0}.", maxim);
            }


            
            return contor;
        }
    }
}
