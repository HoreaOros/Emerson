using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD
{
    class ResizingStackClient
    {
        public static void Main(string[] args)
        {
            ResizingStack<String> stack = new ResizingStack<String>(3);
            stack.push("The");
            stack.push("quick");
            stack.push("brown");
            stack.push("fox");
            stack.push("jumps");
            stack.push("over");
            stack.push("the");
            stack.push("lazy");
            stack.push("dog");

            while (!stack.isEmpty())
            {
                Console.WriteLine(stack.pop());
            }
        }
    }
}
