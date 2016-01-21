using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 4, -2, 6, 0, 4, -1, 6, 9 };

            Console.WriteLine("Suma elementelor din vector este: {0}", v.Sum());

            int suma;
            suma = Suma(v);
            Console.WriteLine("Suma elementelor din vector este: {0}", v.Sum());

            int max;
            max = v.Max();
            Console.WriteLine("Cel mai mare element din vector este: {0}", max);

            max = Maxim(v);

            int key = -1, pozitie;
            bool gasit = Caut(v, key, out pozitie);
            if (gasit)
            {
                Console.WriteLine("Am gasit cheia {0} pe pozitia {1}", key, pozitie);
            }
            else
            {
                Console.WriteLine("Nu am gasit cheia {0} in vector");
            }


            Action<int> fd;
            // 1.
            // *
            // **
            // ***
            // ****

            Star s = new Star(4);
            s.Draw();

          
            // 2. 
            // 1
            // 1 2 
            // 1 2 3 
            // 1 2 3 4 
            fd = f2;
            F(fd);


            // 3.
            // 1
            // 2 3 
            // 3 4 5 
            // 4 5 6 7
            fd = f3;
            F(fd);

            // 4.
            // 1
            // 2 2 
            // 3 3 3
            // 4 4 4 4 
            fd = f4;
            F(fd);
            



        }

        private static void f4(int v)
        {
            for (int i = 1; i <= v; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        private static void f3(int v)
        {
            for (int i = 1; i <= v; i++)
            {
                for (int j = i; j <= 2 * i - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void f2(int v)
        {
            for (int i = 1; i <= v; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void F(Action<int> fd)
        {
            fd(4);
        }

       

        private static bool Caut(int[] v, int key, out int pozitie)
        {
            pozitie = -1;
            bool gasit = false;
            for (int i = 0; i < v.Length && !gasit; i++)
            {
                if (v[i] == key)
                {
                    gasit = true;
                    pozitie = i;
                }
            }
            return gasit;
        }

        private static int Maxim(int[] v)
        {
            int max = v[0];
            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] > max)
                {
                    max = v[i];
                }
            }
            

            max = v[0];
            foreach (var item in v)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return max;
        }

        private static int Suma(int[] v)
        {
            int s = 0;
            for (int i = 0; i < v.Length; i++)
            {
                s += v[i];
            }
            return s;
        }
    }
}
