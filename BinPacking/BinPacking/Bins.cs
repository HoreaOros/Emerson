using System;
using System.Collections.Generic;

namespace BinPacking
{
    internal class Bins
    {
        private int capacity;
        private int count;
        private List<Bin> binlist = new List<Bin>();

        public Bins(int capacity)
        {
            this.capacity = capacity;
            this.count = 0;
        }
        public int Count
        {
            get
            {
                return binlist.Count;
            }
        }

        /// <summary>
        /// Next Fit
        /// </summary>
        /// <param name="item"></param>
        public void Add(int item)
        {
            Bin currentBin = null;
            if (count == 0)
            {
                binlist.Add(new Bin(capacity));
                count++;
                currentBin = binlist[0];
            }
            else
            {
                currentBin = binlist[count - 1];
            }

            bool result = currentBin.Add(item);
            if (result == false)
            {
                binlist.Add(new Bin(capacity));
                count++;
                currentBin = binlist[count - 1];
                currentBin.Add(item);
            }
        }
        /// <summary>
        /// FirstFit
        /// </summary>
        /// <param name="item"></param>
        public void AddFF(int item)
        {
            Bin currentBin = null;
            if (count == 0)
            {
                binlist.Add(new Bin(capacity));
                count++;
                currentBin = binlist[0];
            }
            int i;
            for (i = 0; i < count; i++)
            {
                if (capacity - binlist[i].Total >= item)
                {
                    binlist[i].Add(item);
                    break;
                }
            }
            if (i == count)
            {
                Bin bin = new Bin(capacity);
                bin.Add(item);

                binlist.Add(bin);
                count++;
            }

        }
        public List<Bin> Items
        {
            get
            {
                return binlist;
            }
        }
    }
}