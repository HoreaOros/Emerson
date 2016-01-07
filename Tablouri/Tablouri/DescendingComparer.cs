using System;
using System.Collections;
using System.Collections.Generic;

namespace Tablouri
{
    internal class DescendingComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x > y)
                return -1;
            else if (x == y)
                return 0;
            else
                return 1;
        }
    }
}