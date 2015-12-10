using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatoriSiInstructiuni
{
    class Program
    {
        static void Main(string[] args)
        {
            // intregi pe 32 de biti;
            int numar1, numar2; // [-2^31..2^31 - 1]
            numar1 = 10; numar2 = 30;
            int numar3;
            numar3 = int.MaxValue;

            uint numarFaraSemn; // [0.. 2^32-1]
            numarFaraSemn = uint.MaxValue;

            // intregi 8 biti
            byte b1; // [0..255]
            b1 = byte.MaxValue;

            sbyte sb;
            sb = sbyte.MinValue; // [-128..127]


            // intregi pe 16 biti
            short s;
            s = short.MaxValue; // [-32768..32767]

            ushort us;
            us = 10000; // [0..655353]

            // intregi pe 64 biti
            long l;
            l = long.MaxValue; // [-2^63..2^63-1]

            ulong ul;
            ul = ulong.MaxValue; // [0..2^64-1]


            numar3 = numar1 + numar2;
            numar3 = numar1 - numar2;
            numar3 = numar1 * numar2;
            numar3 = numar1 / numar2; // 7 / 3 -> 2
            numar3 = numar1 % numar2; // 7 % 3 -> 1
            numar1++;
            numar2--;


            double d1; // se reprezinta pe 64 de biti
            d1 = 3.14;

            double pi;
            pi = Math.PI;

            Console.WriteLine("PI = {0:F3}", pi);

            double f1 = 0.0; // se reprezinta pe 32 de biti

            for (int i = 0; i < 1000000; i++)
            {
                f1 = f1 + 0.01;
            }
            Console.WriteLine(f1);

            decimal m1; // util cand avem nevoie de precizie mai buna
            m1 = 1.123456m;


        }
    }
}
