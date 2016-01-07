using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContBancar
{
    class Cont
    {
        private string id;
        private int sold;
        public Cont(string id) : this(id, 0)
        {
            // aici se mai poate scrie cod;
        }
        public Cont(string id, int sold)
        {
            this.sold = sold;
            this.id = id;
        }

        public void Retrage(int v)
        {
            if (v <= sold)
            {
                sold -= v;
                Console.WriteLine("Din contul {0} a fost retrasa suma {1}", id, v);
            }
            else
                throw new NotEnoughFundsException("Suma pe care doriti sa e retargeti este prea mare");
        }

        public void Depune(int v)
        {
            if (v >= 0)
            { 
                sold += v;
                Console.WriteLine("In contul {0} a fost depusa suma {1}", id, v);
            }
            else
                throw new InvalidAmmountException("Suma pe care doriti sa o depuneti nu este valida");
        }

        public override string ToString()
        {
            return string.Format("ID: {1}, Sold: {0}", sold, id);
        }

    }
}
