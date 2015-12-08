using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instructiuni
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber;

            randomNumber = rnd.Next(10); // operator de atribuire

            int incercari = 3;

            while (incercari > 0)
            {
                Console.WriteLine("Incercati sa ghiciti numarul generat! (0-9)");
                string line = Console.ReadLine();
                int numarGhicit;
                numarGhicit = int.Parse(line);

                incercari--;

                if (randomNumber == numarGhicit) // operator de egalitate
                {
                    Console.WriteLine("Felicitari! Ati ghicit numarul.");
                    break;
                }
                else
                {
                    Console.WriteLine("Raspuns gresit. ");
                    if (incercari == 0)
                    {
                        Console.WriteLine("Ati epuizat numarul de incercari pe care l-ati avut la dispozitie");
                    }
                } 
            }

            
            Console.WriteLine("Numarul pseudoaleator generat este: {0}", randomNumber);
        }
    }
}
