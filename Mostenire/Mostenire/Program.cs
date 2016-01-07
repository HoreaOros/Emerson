using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment s = new Segment(new Point(10, 30), new Point(20, 40));
            Dreptunghi d = new Dreptunghi(new Point(15, 25), new Point(10, 30));
            Elipsa e = new Elipsa(new Point(5, 25), new Point(15, 60));

            s.Draw();
            d.Draw();
            e.Draw();
        }
    }
}
