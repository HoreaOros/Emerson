using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
namespace ASD
{
    class ThreeSum
    {
        public static int count(int[] arr)
        {
            int contor = 0;
            int n = arr.Length;

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    for (int k = j + 1; k < n; k++)
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            contor++;
                        }
            return contor;
        }

        public static int countParallel(int[] arr)
        {
            int contor = 0;
            int n;
            n = arr.Length;

            Parallel.For(0, n, i =>
            {
                for (int j = i + 1; j < n; j++)
                    for (int k = j + 1; k < n; k++)
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            Interlocked.Increment(ref contor);
                        }
            });

            return contor;
        }
        public static int countParallel2(int[] arr)
        {
            int contor1 = 0, contor2 = 0;
            int n;
            n = arr.Length;

            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < n / 2; i++)
                    for (int j = i + 1; j < n; j++)
                        for (int k = j + 1; k < n; k++)
                            if (arr[i] + arr[j] + arr[k] == 0)
                            {
                                contor1++;
                            }
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = n / 2; i < n; i++)
                    for (int j = i + 1; j < n; j++)
                        for (int k = j + 1; k < n; k++)
                            if (arr[i] + arr[j] + arr[k] == 0)
                            {
                                contor2++;
                            }
            });

            Task.WaitAll(t1, t2);
            return contor1 + contor2;
        }


       

        public static int countFast(int []arr)
        {
            int contor = 0;
            int n;
            n = arr.Length;
            Array.Sort(arr);

            for (int i = 0; i < n; i++)
                for (int j = i + 1; j < n; j++)
                    if (BinarySearch.rank(-arr[i] - arr[j], arr) > j)
                        contor++;
            return contor;
        }
        public static int countFaster(int[] arr)
        {
            int contor = 0;
            int n;
            n = arr.Length;
            Array.Sort(arr);

            // trebuie scrisa o secventa liniara care determina cate triplete de numere din vectorul arr au suma 0
            // TODO

            return contor;
        }
        public static void Main(string[] args)
        {

            //Stopwatch sw = new Stopwatch();

            //sw.Start();
            //int[] arr = Util.readInts("1Kints.txt");
            //Console.WriteLine(count(arr) + " triplete cu suma 0");
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //sw.Restart();
            //arr = Util.readInts("2Kints.txt");
            //Console.WriteLine(count(arr) + " triplete cu suma 0");
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //sw.Restart();
            //arr = Util.readInts("4Kints.txt");
            //Console.WriteLine(count(arr) + " triplete cu suma 0");
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //sw.Restart();
            //arr = Util.readInts("8Kints.txt");
            //Console.WriteLine(count(arr) + " triplete cu suma 0");
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);


            int[] arr = Util.readInts("2Kints.txt");

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(count(arr) + " triplete cu suma 0 - lent");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Restart();
            Console.WriteLine(countFast(arr) + " triplete cu suma 0 - rapid");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Restart();
            Console.WriteLine(countParallel(arr) + " triplete cu suma 0 - paralel");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);


            sw.Restart();
            Console.WriteLine(countParallel2(arr) + " triplete cu suma 0 - paralel 2");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            Console.ReadKey();
        }
    }
}
