using System;

namespace Secvente
{
    internal class Star
    {
        private int v;

        public Star(int v)
        {
            this.v = v;
        }

        internal void Draw()
        {
            for (int i = 1; i <= v; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}