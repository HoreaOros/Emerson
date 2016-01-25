using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // & SI pe biti
            // | SAU pe biti
            // ^ XOR pe biti (SAU eXclusive)
            // ~ complement pe biti
            // <<, >> deplasare pe biti

            uint a = 1258, b = 25689;

            // a     = 000...000000010011101010
            // b     = 000...000110010001011001
            // a & b = 000...000000010001001000
            // a | b = 000...000110010011111011
            // a ^ b = 000...000110000010110011
            uint and_ab = a & b;
            uint or_ab = a | b;
            uint xor_ab = a ^ b;
            uint compl_ab = ~a;
            uint depl_a = a << 3;
            uint depl_b = b >> 4;

            SetBit(ref a, 7);
            ResetBit(ref a, 7);
            GetBit(a, 7);

            // XOR - eXclusive OR
            // m = 0011
            // p = 1001
            // --------
            // c = 1010
            // p = 1001
            // --------
            // m = 0011 
            uint mask = 0;
            int z = Convert.ToInt32("11001001", 2);
        }

        private static uint GetBit(uint a, int v)
        {
            uint mask = 1u;

            // mask = mask | (mask << 1);

            return (a >> v) & mask;
        }

        private static void ResetBit(ref uint a, int v)
        {
            uint mask = 1u;

            mask = ~(mask << v);
            a = a & mask;
            // mask = 111...111101111111
            //    a = 000...010010100101
        }

        private static void SetBit(ref uint a, int v)
        {
            uint mask = 1u;

            mask = mask << v;
            a = a | mask;
            // mask = 000...000010000000
            //    a = 000...010010100101
        }

    }
}
