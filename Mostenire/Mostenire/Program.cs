using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nu se poate instantia o clasa abstracta
            //Shape sh = new Shape(new Point(0, 0), new Point(10, 10));
            Segment s = new Segment(new Point(10, 30), new Point(20, 40));
            Dreptunghi d = new Dreptunghi(new Point(15, 25), new Point(10, 30));
            Elipsa e = new Elipsa(new Point(5, 25), new Point(15, 60));

            //sh.Draw();
            //s.Draw();
            //d.Draw();
            //e.Draw();

            //Desenare(sh);
            Desenare(s);
            Desenare(d);
            Desenare(e);


            //Shape[] shapes = new Shape[100];
            //shapes[0] = new Segment(new Point(10, 30), new Point(20, 40));

            Random rnd = new Random();
            var lstShapes = new List<Shape>();
            
            for (int i = 0; i < 10; i++)
            {
                
                switch (rnd.Next(3))
                {
                    case 0:
                        lstShapes.Add(
                            new Segment(new Point(rnd.Next(100), rnd.Next(100)),
                                        new Point(rnd.Next(100), rnd.Next(100))
                            ));
                        break;
                    case 1:
                        lstShapes.Add(
                            new Dreptunghi(new Point(rnd.Next(100), rnd.Next(100)),
                                        new Point(rnd.Next(100), rnd.Next(100))
                            ));
                        break;
                    case 2:
                        lstShapes.Add(
                            new Elipsa(new Point(rnd.Next(100), rnd.Next(100)),
                                        new Point(rnd.Next(100), rnd.Next(100))
                            ));
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Colectia de forme geometrice:");
            foreach (var item in lstShapes)
            {
                item.Draw();
                Printare(item);
            }
           
        }

        static void Desenare(Shape s)
        {
            s.Rotate();
            s.Draw();
        }
        static void Printare(IPrintable p)
        {
            p.Print();
        }
    }
}
