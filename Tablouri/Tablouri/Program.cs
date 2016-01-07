using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tablouri
{
    class Program
    {
        static void Main(string[] args)
        {

            // Initial toate elementele vectorului sunt initializate cu zero
            int[] numere;

            numere = new int[100];


            PrintArray(numere);

            Random rnd = new Random();

            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = rnd.Next(100);
            }
            

            PrintArray(numere);

            int index = Array.IndexOf(numere, 42);

            if (index >= 0)
            {
                Console.WriteLine("Numarul 42 se gaseste in vectorul numere pe pozitia {0}", index);
            }
            else
                Console.WriteLine("Numarul 42 nu se gaseste in vectorul numere");

            Array.Sort(numere);
            PrintArray(numere);

            Array.Sort(numere, new DescendingComparer());
            PrintArray(numere);


            Array.Sort(numere, new DigitSumComparer());
            PrintArray(numere);


            Dublare(numere);
            PrintArray(numere);

        }

        private static void Dublare(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                // arr[i] = arr[i] * 2;
                arr[i] *= 2;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }
    }
}
