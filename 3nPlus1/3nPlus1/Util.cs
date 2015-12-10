using System;

namespace _3nPlus1
{
    class Util
    {
        internal static int ExtractInt()
        {
            string line;
            Console.WriteLine("Introduceti un numar intreg");

            line = Console.ReadLine();

            int n = 0;
            bool result = int.TryParse(line, out n);
            if (result == false)
            {
                Console.WriteLine("Nu s-a introdus un numar corect");
            }

            return n;
        }
    }
}