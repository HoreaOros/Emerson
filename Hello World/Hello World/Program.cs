using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Hello World of C#!!");

            int number; // un numar intreg cuprins intre -2.147.000.000 si 2.147.000.000

            number = 42;

            number = 43;

            number++;

            number = number + 1;

            number = number * 2;

            number = number % 85; // restul impartirii

            number = number / 3; // impartire intreaga (catul impartirii)


            Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
