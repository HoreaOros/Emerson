using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary Search Tree
            BST<string, int> b = new BST<string, int>();

            b.Add("f", 2);
            b.Add("a", 4);
            b.Add("z", 3);
            b.Add("d", 5);
            b.Add("b", 1);
            b.Add("m", 10);

            b.Inorder();

            Console.WriteLine("{0}", b["z"]);
        }
    }
}
