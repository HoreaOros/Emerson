using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mostenire;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lstShapes = new List<Shape>();

            using (StreamReader sr = new StreamReader("input.txt"))
            {
                string line;
                string[] tokens;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    tokens = line.Split(' ');
                    int x1, y1, x2, y2;
                    x1 = int.Parse(tokens[1]);
                    y1 = int.Parse(tokens[2]);
                    x2 = int.Parse(tokens[3]);
                    y2 = int.Parse(tokens[4]);
                    switch (tokens[0].ToLower())
                    {
                        case "elipsa":
                            lstShapes.Add(new Elipsa(new Point(x1, y1), new Point(x2, y2)));
                            break;
                        case "dreptunghi":
                            lstShapes.Add(new Dreptunghi(new Point(x1, y1), new Point(x2, y2)));
                            break;
                        case "segment":
                            lstShapes.Add(new Segment(new Point(x1, y1), new Point(x2, y2)));
                            break;
                        default:
                            break;
                    }
                }

                foreach (var item in lstShapes)
                {
                    item.Draw();
                }

                lstShapes.Sort();

                foreach (var item in lstShapes)
                {
                    item.Draw();
                }
            }
        }
    }
}


    