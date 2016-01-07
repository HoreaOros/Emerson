using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
HorzBar
+----------+

VertBar
|
|
|
|
|

Frame
+------+
|
|
|
+------+

Ladder
+------+
|
|
|
+------+
|
|
|
+------+
|
|
|
+------+

*/
namespace Bars
{
    class Program
    {
        static void Main(string[] args)
        {
            HorzBar h1 = new HorzBar(5);
            Console.WriteLine("Latimea barei orizontale este: {0}", h1.Width);

            VertBar v1 = new VertBar(3);
            Console.WriteLine("Inaltimea barei verticale este: {0}", v1.Height);
            Frame f1 = new Frame(10, 8);

            Console.WriteLine("Latimea frame-ului f1 este: {0}", f1.Width);
            Console.WriteLine("Inaltimea frame-ului f1 este: {0}", f1.Height);

            Ladder l = new Ladder(6, 4);
        }
    }
}
