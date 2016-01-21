using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecventeReloaded
{
    class Program
    {
        static int Add(params int[] v)
        {
            int suma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                suma += v[i];
            }
            return suma;
        }
        static void Main(string[] args)
        {
            try
            {
                int[] v = { 1, 3, 4, -3, 5, 2, 0, 17 };

                #region ParamsRegion
                Console.WriteLine("Suma = {0}", Add(v));
                Console.WriteLine("Suma = {0}", Add(1));
                Console.WriteLine("Suma = {0}", Add(1, 2));
                Console.WriteLine("Suma = {0}", Add(1, 2, 3));
                #endregion

                StreamReader sr = new StreamReader("input.txt");

                string line = sr.ReadToEnd();
                char[] seps = { ' ', ',', '\n', '\t' };

                string[] tokens = line.Split(seps, StringSplitOptions.RemoveEmptyEntries);
                int[] w = new int[tokens.Length];
                for (int i = 0; i < tokens.Length; i++)
                {
                    w[i] = int.Parse(tokens[i]);
                }
                int[] r = SecventaCrescatoare(w);
                Console.WriteLine("O secventa lunga ;) este:");
                foreach (var item in r)
                {
                    Console.WriteLine(string.Format("{0} ", item));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
        /// <summary>
        /// Determina o subsecventa lunga dintr-un vector
        /// </summary>
        /// <param name="w">Vectorul in care se cauta</param>
        /// <returns>Vector care contine secventa gasita</returns>
        private static int[] SecventaCrescatoare(int[] w)
        {
            int maxIndex = 0;
            int maxLength = 0;

            for (int i = 0; i < w.Length; i++)
            {
                int length = 1;
                int a = w[i];
                for (int j = i + 1; j < w.Length; j++)
                {
                    if (w[j] > a)
                    {
                        length++;
                        a = w[j];
                    }
                }
                if (length > maxLength)
                {
                    maxLength = length;
                    maxIndex = i;
                }
            }

            // Construirea rezultatului
            int[] r = new int[maxLength];
            r[0] = w[maxIndex];
            int k = 0;
            for (int i = maxIndex + 1; i < w.Length; i++)
            {
                if (w[i] > r[k])
                {
                    k++;
                    r[k] = w[i];
                }
            }

            return r;
        }
    }
}
