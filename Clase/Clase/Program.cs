using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicul v1 = new Vehicul("VW", "Passat", 2002, 
                new Motor(4, 170, Combustibil.Diesel));

            Console.WriteLine(v1);

            v1.Start();
            v1.Status();

            v1.ChangeGear(1);
            v1.Status();

            v1.Accelerate();
            v1.Status();
            //v1.Break();
            v1.ChangeGear(0);
            v1.Status();

            v1.Stop();
            v1.Status();

            Console.ReadKey();
        }
    }
}
