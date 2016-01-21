using System.Collections.Generic;
using System.Text;

namespace BinPacking
{
    internal class Bin
    {
        private int capacity;
        private List<int> items;

        public Bin(int capacity)
        {
            this.capacity = capacity;
            items = new List<int>();
        }
        /// <summary>
        /// Cat din capacitatea este umplut
        /// </summary>
        public int Total
        {
            get
            {
                int suma = 0;
                foreach (var item in items)
                {
                    suma += item;
                }
                return suma;
            }
        }
        
        public bool Add(int item)
        {
            if (capacity - Total >= item)
            {
                items.Add(item);
                return true;
            }
            return false;
        }
        public int Count
        {
            get
            {
                return items.Count;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in items)
            {
                sb.Append(item + ", ");
            }
            sb.Append("]");

            return sb.ToString();
        }
    }
}