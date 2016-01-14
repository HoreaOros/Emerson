using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    public class Segment : Shape
    {
        public Segment(Point p1, Point p2) : base(p1, p2)
        {
            Console.WriteLine("Am creat un segment");
        }
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Am desenat un segment");
        }
        public override void Draw(Color c)
        {
            // base.Draw(c);
            Console.WriteLine("Am desenat un segment colorat");
        }

        public override void Print()
        {
            Console.WriteLine("Am trimis la imprimanta un segment");
        }
    }
}
