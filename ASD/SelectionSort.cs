﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ASD
{
    class SelectionSort
    {
        /// <summary>
        /// Nu permitem instantierea clasei
        /// </summary>
        private SelectionSort()
        {

        }
        public static void Main(string[] args)
        {
            string filename = "words3.txt";
            string[] a = Util.readWords(filename);

            int[] b = { 3, 2, 1 };

            sort(b);

            Debug.Assert(isSorted(b), "Vectorul nu este sortat");

            show(b);

        }

        /// <summary>
        /// Selection sort. Toate elementele din stanga pozitiei i sunt ordonate si sunt cele mai mici i elemente din vector
        /// </summary>
        /// <param name="a"></param>
        public static void sort<T>(T[] a) where T: IComparable<T>
        {
            int i, j;
            int n = a.Length;
            int min;
            for (i = 0; i < n; i++)
            {
                min = i;
                for (j = i + 1; j < n; j++)
                    if (less(a[j], a[min]))
                        min = j;
                exch(a, i, min);
            }
        }


        /// <summary>
        /// Metoda privata ajutatoare pentru a determina daca un element este mai mic decat altul
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        private static bool less<T>(T p, T q) where T: IComparable<T>
        {
            return p.CompareTo(q) < 0;
        }
        /// <summary>
        /// Metoda privata ajutatoare care interschimba doua valori din vector
        /// </summary>
        /// <param name="a"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private static void exch<T>(T[] a, int i, int j) where T: IComparable<T>
        {
            T t;
            t = a[i];
            a[i] = a[j];
            a[j] = t;
        }
        /// <summary>
        /// Metoda privata ajutatoare care afiseaza elementele vectorului pe o singura linie
        /// </summary>
        /// <param name="a">Vector de elemente</param>
        private static void show<T>(T[] a) where T: IComparable<T>
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Metoda care determina daca vectorul este sortat
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool isSorted<T>(T[] a) where T: IComparable<T>
        {
            for (int i = 1; i < a.Length; i++)
                if (less(a[i], a[i - 1]))
                    return false;
            return true;
        }
    }
}
