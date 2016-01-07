using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    class Program
    {
        static void Main(string[] args)
        {
            Cont c1 = new Cont("01");
            Cont c2 = new Cont("02", 100);

            Console.WriteLine(c1); 
            Console.WriteLine(c2);



            try
            {
                c1.Depune(100);
            }
            catch (InvalidAmmountException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                c1.Retrage(300);
            }
            catch (NotEnoughFundsException e)
            {
                Console.WriteLine(e.Message);
            }


            Operatii1(c1);
            Operatii2(ref c1);
        }

        private static void Operatii2(ref Cont c) // transmitere de referinta prin referinta
        {
            // referinta se modifica si modificarea ramane si dupa terminarea metodei.
            c = new Cont("03", 500);
        }

        private static void Operatii1(Cont c) // transmitere de referinta prin valoare
        {
            // obiectul referit se poate modifica dar referinta ramane neomodificata
            c.Depune(200);
            c.Depune(300);
            c.Retrage(400);
        }

    }
}
