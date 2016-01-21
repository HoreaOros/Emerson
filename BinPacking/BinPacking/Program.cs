using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinPacking
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 10;
            int[] w = { 3, 6, 2, 1, 5, 7, 2, 4, 1, 9 };

            Bins bins = new Bins(capacity);

            foreach (var item in w)
            {
                bins.AddFF(item);
            }

            Console.WriteLine("Numarul de containere folosite este: {0}", bins.Count);

            foreach (var item in bins.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
