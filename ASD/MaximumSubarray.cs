﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD
{
    /// <summary>
    /// Determina cea mai mare suma a unei subsecvente compacte dintr-un tablou
    /// </summary>
    static class MaximumSubarray
    {
        /// <summary>
        /// Determina cea mai mare suma a unei subsecvente compacte a tabloului cu un algoritm eficient
        /// </summary>
        /// <param name="arr">Numerele procesate</param>
        /// <returns>Suma maxima a unei subsecvente compacte</returns>
        /// <seealso cref="http://www.infoarena.ro/probleme-cu-secvente"/>
        public static int MaximumSubArrayLiniar(int[] arr)
        {
            
            
            // sum[i] = suma elementelor din vector pana la i
            int[] sume = new int[arr.Length];
            
            sume[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                sume[i] = sume[i - 1] + arr[i];
            }


            int sumaMaxima = int.MinValue;
            int minim = 0;
            int[] maxim = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                // cea mai mare suma a unei subsecvente a sirului pana la indexul i
                maxim[i] = sume[i] - minim;

                if (minim > sume[i])
                    minim = sume[i];

                if (sumaMaxima < maxim[i])
                    sumaMaxima = maxim[i];
            }

            return sumaMaxima;
        }
        /// <summary>
        /// Determina cea mai mare suma a unei subsecvente compacte a tabloului cu un algoritm ineficient. 
        /// Calculeaza toate sumele posibile. 
        /// </summary>
        /// <param name="arr">Numerele procesate</param>
        /// <returns>Suma maxima a unei subsecvente compacte</returns>
        public static int MaximumSubarrayBrut(int[] arr)
        {
            int maxim = int.MinValue;
            int i, j, suma;
            for (i = 0; i < arr.Length; i++)
            {
                suma = 0;
                for (j = i; j < arr.Length; j++)
                {
                    suma += arr[j];
                    if (suma > maxim)
                        maxim = suma;
                }
            }

            return maxim;
        }
    }
}
