﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace ASD
{
    class MaxPQ<Key> where Key: IComparable<Key>
    {
        private Key[] pq;
        private int N;
        private IComparer<Key> comparator;
        /// <summary>
        /// Initializeaza un MaxPQ cu capacitatea initiala data
        /// </summary>
        /// <param name="initCapacity">capacitatea initiala a cozii cu prioritate</param>
        public MaxPQ(int initCapacity)
        {
            pq = new Key[initCapacity + 1];
            N = 0;
        }
        /// <summary>
        /// Initializeaza un MaxPQ gol
        /// </summary>
        public MaxPQ(): this(1)
        {
          
        }
        /// <summary>
        /// Initializeaza o coada cu prioritate cu cheile din vectorul transmis ca argument
        /// </summary>
        /// <param name="keys">vectorul de chei</param>
        public MaxPQ(Key[] keys) 
        {
            N = keys.Length;
            pq = new Key[keys.Length + 1]; 

            for (int i = 0; i < N; i++)
                pq[i+1] = keys[i];

            for (int k = N/2; k >= 1; k--)
                sink(k);

            Debug.Assert(isMaxHeap());
        }
        /// <summary>
        /// Initializeaza un MaxPQ cu capacitatea initiala data si comparatorul dat 
        /// </summary>
        /// <param name="initCapacity">capacitatea initiala a cozii cu prioritate</param>
        /// <param name="comparator">Comparatorul folosit pentru stabilirea ordinii cheilor</param>
        public MaxPQ(int initCapacity, IComparer<Key> comparator)
        {
            this.comparator = comparator;
            pq = new Key[initCapacity + 1];
            N = 0;
        }
        /// <summary>
        /// E goala coada cu prioritate?
        /// </summary>
        /// <returns>true daca coada cu prioritate este goala; false altfel</returns>
        public bool isEmpty()
        {
            return N == 0;
        }
        /// <summary>
        /// Intoarce numarul de chei din coada cu prioritate
        /// </summary>
        /// <returns>numarul de chei din coada cu prioritate</returns>
        public int size()
        {
            return N;
        }
        /// <summary>
        /// Intoarce cea mai mare cheie din coada cu prioritate
        /// </summary>
        /// <returns>cea mai mare cheie din coada cu prioritate</returns>
        public Key max()
        {
            if (isEmpty()) 
                throw new NoSuchElementException();
            return pq[1];
        }
        /// <summary>
        /// Functie ajutatoare care redimensioneaza coada cu prioritate
        /// </summary>
        /// <param name="capacity">Noua dimensiune a cozii cu prioritate</param>
        private void resize(int capacity) 
        {
            Debug.Assert(capacity > N);

            Key[] temp = new Key[capacity];
            for (int i = 1; i <= N; i++) 
                temp[i] = pq[i];

            pq = temp;
        }
        /// <summary>
        /// Adaugam o noua cheie in coada cu prioritate
        /// </summary>
        /// <param name="x">noua cheie care se adauga la coada cu prioritate</param>
        public void insert(Key x) 
        {

            // dublam capacitatea vectorului daca e necesar
            if (N >= pq.Length - 1) 
                resize(2 * pq.Length);

            // adaugam x si il mutam la locul lui pentru a mentine structura de date heap
            pq[++N] = x;
            swim(N);

            Debug.Assert(isMaxHeap());
        }
        /// <summary>
        /// Elimina din coada cu prioritate cel mai mare element si il intoarce ca rezultat
        /// </summary>
        /// <returns>cea mai mare cheie din coada cu prioritate</returns>
        public Key delMax() 
        {
            if (isEmpty()) 
                throw new NoSuchElementException();
            
            Key max = pq[1];
            exch(1, N--);
            sink(1);
            pq[N+1] = default(Key);     // util pentru garbage collection 
            if ((N > 0) && (N == (pq.Length - 1) / 4)) 
                resize(pq.Length / 2);
            
            Debug.Assert(isMaxHeap());
            
            return max;
        }
        private void swim(int k)
        {
            while (k > 1 && less(k / 2, k))
            {
                exch(k, k / 2);
                k = k / 2;
            }
        }

        private void sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;
                if (j < N && less(j, j + 1)) 
                    j++;
                if (!less(k, j)) 
                    break;
                exch(k, j);
                k = j;
            }
        }
        private bool less(int i, int j)
        {
            if (comparator == null)
            {
                return pq[i].CompareTo(pq[j]) < 0;
            }
            else
            {
                return comparator.Compare(pq[i], pq[j]) < 0;
            }
        }

        private void exch(int i, int j)
        {
            Key swap = pq[i];
            pq[i] = pq[j];
            pq[j] = swap;
        }
        // Este pq[1..N] un max heap?
        private bool isMaxHeap()
        {
            return isMaxHeap(1);
        }
        // Este subarborele lui pq[1..N] cu radacina in  k un max heap?
        private bool isMaxHeap(int k)
        {
            if (k > N) 
                return true;
            int left = 2 * k, right = 2 * k + 1;

            if (left <= N && less(k, left)) 
                return false;
            if (right <= N && less(k, right)) 
                return false;
            
            return isMaxHeap(left) && isMaxHeap(right);
        }
        
        
    }
}
