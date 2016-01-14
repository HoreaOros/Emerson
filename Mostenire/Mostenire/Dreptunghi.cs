using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    public class Dreptunghi : Shape
    {
        public Dreptunghi(Point p1, Point p2) : base(p1, p2)
        {
            Console.WriteLine("Am creat un dreptunghi");
        }
        public int Perimetru()
        {
            return 0;
        }
        public override void Draw()
        {
            // base.Draw();
            Console.WriteLine("Am desenat un dreptunghi");
        }
        public override void Draw(Color c)
        {
            Console.WriteLine("Am desenat un dreptunghi colorat");
        }

        public override void Print()
        {
            Console.WriteLine("Am trimis la imprimanta un dreptunghi");
        }
    }

}
