using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    public class Elipsa : Shape
    {
        public Elipsa(Point p1, Point p2) : base(p1, p2)
        {
            Console.WriteLine("Am creat o elipsa");
        }
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Am desenat o elipsa"); 
        }
        public override void Draw(Color c)
        {
            Console.WriteLine("Am desenat o elipsa colorata");
        }

        public override void Print()
        {
            Console.WriteLine("Am trimis la imprimanta o elipsa");
        }
    }
}
