using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mostenire
{
    public abstract class Shape: IPrintable, IComparable<Shape>
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
        //public virtual void Draw()
        //{
        //    Console.WriteLine("Am desenat o forma geometrica");
        //}
        //public virtual void Draw(Color c)
        //{
        //    Console.WriteLine("Am desenat o forma geometrica colorata");
        //}
        public abstract void Draw();
        public abstract void Draw(Color c);
        public void Rotate()
        {
            Console.WriteLine("Am rotit forma geometrica");
        }

        abstract public void Print();

        public int CompareTo(Shape other)
        {
            if (this.p1.X < other.p1.X)
                return -1;
            else if (this.p1.X > other.p1.X)
                return 1;
            else
                return 0;
        }

        //public abstract void M();
    }
}
