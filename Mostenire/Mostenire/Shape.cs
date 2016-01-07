using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    class Shape
    {
        Point p1, p2;
        Color lineColor;
        Color fillColor;

        public Shape(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            lineColor = Color.Blue;
            fillColor = Color.Red;
            Console.WriteLine("Am creat o forma geometrica");
        }
        public void Draw()
        {
            Console.WriteLine("Am desenat o forma geometrica");
        }
    }
}
