using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 42;
            Console.WriteLine("Numarul {0} {1}este par", n, EstePar(n)?"":"nu ");

            int m = 123;
            // nr. prime: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29,...
            Console.WriteLine("Numarul {0} {1}este prim", m, EstePrim3(m) ? "" : "nu ");

            n = 1234321; // Palindrom
            Console.WriteLine("Numarul {0} {1}este palindrom", n, Palindrom3(n) ? "" : "nu ");

            n = 24; // 2^3 * 3^1
            Factori(n);

            n = 1238679;
            Console.WriteLine("Cifrele numarului {0} {1}sunt in ordine crescatoare", n, Crescator(n)? "" : "nu ");

        }

        private static bool Palindrom3(int n)
        {
            string s = n.ToString();

            var r = s.Reverse<char>();

            // 1. 
            string reverseS1 = string.Concat(r);

            // 2. 
            string reverseS2 = new string(r.ToArray<char>());

            // 3. 
            StringBuilder sb = new StringBuilder();
            foreach (var item in r)
            {
                sb.Append(item);
            }
            string reverseS3 = sb.ToString();


            return s == reverseS1;
        }

        private static bool Crescator(int n)
        {
            int a, b;
            bool ok = true;

            if (n < 10)
            {
                return true;
            }

            b = n % 10;
            n = n / 10; // n /= 10;
            while (n > 0)
            {
                a = n % 10;
                if (a >= b)
                {
                    ok = false;
                    break;
                }
                b = a;
                n = n / 10;
            }
            return ok;
        }

        private static void Factori(int n)
        {
            int d = 2;
            int exp = 0;
            while (n > 1)
            {
                while (n % d == 0)
                {
                    exp++;
                    n = n / d;
                }
                if (exp > 0)
                {
                    Console.Write("{0}^{1}", d, exp);
                    if (n > 1)
                    {
                        Console.Write(" * ");
                    }
                }
                d++;
                exp = 0;
            }
            Console.WriteLine();
        }

        private static bool Palindrom2(int n)
        {
            if (n == Reverse(n))
            {
                return true;
            }
            else
                return false;
        }

        private static int Reverse(int n)
        {
            int r = 0;
            int c;
            while (n > 0)
            {
                c = n % 10;
                r = r * 10 + c;
                n = n / 10;
            }
            return r;
        }
  /*
  n     r       c
  ----------------
  123   0       3
  12    3       2
  1     32      1
  0     321
  */

        private static bool Palindrom(int n)
        {
            string s = n.ToString();
            char[] r = s.ToCharArray();
            Array.Reverse(r);
            string rev = new string(r);

            Debug.WriteLine("s = {0}", s);
            Debug.WriteLine("rev = {0}", rev);


            if (s == rev)
            {
                return true;
            }
            else
                return false;
        }

        private static bool EstePrim3(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            if (n == 2 || n == 3)
            {
                return true;
            }

            int contor = 0;
            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    contor++;
                }
            }

            if (contor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool EstePrim(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            if (n == 2 || n == 3)
            {
                return true;
            }

            int contor = 0;
            for (int d = 2; d <= n / 2; d++)
            {
                if (n % d == 0)
                {
                    contor++;
                }
            }
            if (contor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool EstePrim2(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            if (n == 2 || n == 3)
            {
                return true;
            }

            int contor = 0;
            for (int d = 1; d <= n; d++)
            {
                if (n % d == 0)
                {
                    contor++;
                }
            }
            if (contor == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
            // return (contor == 2) ? true : false;
         }

        private static bool EstePar(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
