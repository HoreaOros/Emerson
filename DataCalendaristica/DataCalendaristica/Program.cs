using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCalendaristica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DateTime azi = DateTime.Now;

            Console.WriteLine(azi);
            Console.WriteLine(azi.ToLongDateString());
            Console.WriteLine(azi.ToLongTimeString());
            Console.WriteLine(azi.ToShortDateString());
            Console.WriteLine(azi.ToShortTimeString());

            Console.WriteLine(azi.ToUniversalTime());
            Console.WriteLine("Ora: {0}, Minutul: {1}, Secunda: {2}", azi.Hour, azi.Minute, azi.Second);

            DateTime azi365;
            azi365 = azi.AddDays(365);
            Console.WriteLine(azi365.ToShortDateString());

            DayOfWeek dow = azi365.DayOfWeek; 
            Console.WriteLine("Peste 365 de zile ziua saptamanii va fi: {0}", dow);

            DateTime d1 = new DateTime(2015, 12, 14);
            DateTime d2 = new DateTime(1970, 1, 1);

            TimeSpan ts = d1.Subtract(d2);

            Console.WriteLine(ts);
            Console.WriteLine(ts.Days); */

            try
            {
                DC d1 = new DC(22, 8, 1977);
                DC d2 = new DC("14.12.2015");
                DC d3 = new DC("14-12-2015");
                DC d4 = new DC("");

                Console.WriteLine(d1);
                Console.WriteLine(d2);
                Console.WriteLine(d3);
                Console.WriteLine(d4);



                int nrZile = DC.DiferentaZile(d1, d2);
                Console.WriteLine("Numarul de zile dintre {0} si {1} este {2}", d1, d2, nrZile);
            }
            catch (Exception)
            {
                Console.WriteLine("Ooops!!! Something went wrong. This is really embarassing. We will investigate!");

            }
            Console.ReadKey();
        }
    }
}
