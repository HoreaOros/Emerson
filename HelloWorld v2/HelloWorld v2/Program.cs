using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            World csharp = new World("C#");
            csharp.SayHello();

            World java = new World("Java");
            java.SayHello();

            World js = new World("JavaScript");
            js.SayHello();


            csharp.SayHello("Salut");
            java.SayHello("Bonjour");


            Console.ReadKey();
        }
    }
}
