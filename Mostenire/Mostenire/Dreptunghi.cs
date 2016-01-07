using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    class Dreptunghi : Shape
    {
        public Dreptunghi(Point p1, Point p2) : base(p1, p2)
        {
            Console.WriteLine("Am creat un dreptunghi");
        }
        public int Perimetru()
        {
            return 0;
        }
    }

}
