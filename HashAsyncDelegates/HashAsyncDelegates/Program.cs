using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.Remoting.Messaging;

namespace HashAsyncDelegates
{
    class Program
    {
        static bool done = false;
        static void Main(string[] args)
        {
            // Creez un fisier mare de 2GB
            string fileName = "fileTohash.in";
            string hashAlgorithm = "MD5";
            FileStream f = File.Create(fileName);
            f.Seek((1U << 31) - 1, SeekOrigin.Begin);
            f.Write(new byte[1] { 0 }, 0, 1);
            f.Close();

            Func<string, string, byte[]> hash = new Func<string, string, byte[]>(CalculHash);

            IAsyncResult iar = hash.BeginInvoke(fileName, hashAlgorithm, HashCallback, null);
            Console.Write("Computing");
            while (!done)
            {
                iar.AsyncWaitHandle.WaitOne(1000, true);
                Console.Write(".");
            }
            Console.WriteLine("Completed!");
            Console.ReadLine();
        }

        private static void HashCallback(IAsyncResult ar)
        {
            AsyncResult r = (AsyncResult)ar;

            Func<string, string, byte[]> delegat = (Func<string, string, byte[]>)r.AsyncDelegate;

            byte[] rezultat = delegat.EndInvoke(ar);

            StringBuilder sb = new StringBuilder();
            foreach (byte item in rezultat)
            {
                sb.AppendFormat("{0:X2}", item);
            }
            Console.WriteLine("Valoarea hash este: {0}", sb.ToString());
        }
        static byte[] CalculHash(string s, string hashAlg)
        {
            FileStream f = new FileStream(s, FileMode.Open, FileAccess.Read);
            HashAlgorithm hAlg = HashAlgorithm.Create(hashAlg);
            byte[] hashValue = hAlg.ComputeHash(f);
            done = true;
            return hashValue;
        }
    }
}
