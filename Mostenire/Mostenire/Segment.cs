using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    class Segment : Shape
    {
        public Segment(Point p1, Point p2) : base(p1, p2)
        {
            Console.WriteLine("Am creat un segment");
        }
    }
}
