using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int number = 0;

            Console.WriteLine("Introduceti un numar:");
            try
            {
                line = Console.ReadLine();
                number = int.Parse(line);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }

            number *= 2;

            Console.WriteLine("Numarul este: {0}. Dublul numarului este: {1}", number, number * 2);

            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
