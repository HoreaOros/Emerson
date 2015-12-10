using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3nPlus1
{
    class Program
    {
        static void Main(string[] args)
        {


            int N;

            N = Util.ExtractInt();

            int lungimeSecventa;
            lungimeSecventa = TreiNPlus1(N);
        }

        private static int TreiNPlus1(int n)
        {
            int contor = 1;

            Console.Write("{0} ", n);
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
                    Console.Write("{0} ", n);
                    contor++;
                } while (n != 1);
                Console.WriteLine("Lungimea secventei este: {0}", contor);
            }

            return contor;
        }
    }
}
