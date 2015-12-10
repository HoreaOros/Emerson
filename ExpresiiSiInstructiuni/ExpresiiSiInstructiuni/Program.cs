using System;
using System.Collections.Generic;
using System.Text;

namespace ExpresiiSiInstructiuni
{
    enum ZiDinSaptamana
    {
        luni,
        marti,
        miercuri,
        joi,
        vineri,
        sambata, 
        duminica
    }
    class Program
    {
        static void Z1(string line)
        {
            
            if (line == "luni" || line == "marti")
            {
                Console.WriteLine("Este inceputul săptămânii.");
            }
            else if (line == "miercuri" || line == "joi")
            {
                Console.WriteLine("Este mijlocul saptamanii");
            }
            else if (line == "vineri")
            {
                Console.WriteLine("Este sfarsitul saptamanii");
            }
            else if (line == "sambata" || line == "duminica")
            {
                Console.WriteLine("Suntem in weekend");
            }
            else
                Console.WriteLine("Trebuia sa introduceti o zi a saptamnii.");
        }
        static void Main(string[] args)
        {
            string line;

            Console.WriteLine("Introduceti ziua saptamanii:");
            line = Console.ReadLine();

            line = line.ToLower().Trim();

            Z1(line);
            Z2(line);
            Z3(line);
        }

        private static void Z3(string line)
        {
            ZiDinSaptamana zi;

           

            zi = (ZiDinSaptamana)Enum.Parse(typeof(ZiDinSaptamana), line);

            switch (zi)
            {
                case ZiDinSaptamana.luni:
                case ZiDinSaptamana.marti:
                    Console.WriteLine("Este inceputul săptămânii.");
                    break;
                case ZiDinSaptamana.miercuri:
                case ZiDinSaptamana.joi:
                    Console.WriteLine("Este mijlocul saptamanii");
                    break;
                case ZiDinSaptamana.vineri:
                    Console.WriteLine("Este sfarsitul saptamanii");
                    break;
                case ZiDinSaptamana.sambata:
                case ZiDinSaptamana.duminica:
                    Console.WriteLine("Suntem in weekend");
                    break;
                default:
                    Console.WriteLine("Trebuia sa introduceti o zi a saptamnii.");
                    break;
            }

        }

        private static void Z2(string line)
        {
            switch (line) // variabila de selectie
            {
                case "luni":
                case "marti":
                    Console.WriteLine("Este inceputul săptămânii.");
                    break;
                case "miercuri":
                case "joi":
                    Console.WriteLine("Este mijlocul saptamanii");
                    break;
                case "vineri":
                    Console.WriteLine("Este sfarsitul saptamanii");
                    break;
                case "sambata":
                case "duminica":
                    Console.WriteLine("Suntem in weekend");
                    break;
                default:
                    Console.WriteLine("Trebuia sa introduceti o zi a saptamnii.");
                    break;
            }
        }
    }
}
