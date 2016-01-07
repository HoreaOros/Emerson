using System;
using System.Collections;
using System.Collections.Generic;

namespace Tablouri
{
    internal class DigitSumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int sx, sy;
            sx = SumaCifre(x);
            sy = SumaCifre(y);

            if (sx < sy)
                return -1;
            else if (sx == sy)
                return 0;
            else
                return 1;
        }

        private int SumaCifre(int x)
        {
            int suma = 0;

            while (x > 0)
            {
                suma = suma + x % 10;
                x = x / 10;
            }


            return suma;
        }
    }
}