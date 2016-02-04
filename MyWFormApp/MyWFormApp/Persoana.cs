using System;
using System.Text;
namespace MyWFormApp
{
    public class Persoana
    {
        string nume, prenume;
        DateTime dataNasterii;

        public Persoana(string nume, string prenume, DateTime dataNasterii)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.dataNasterii = dataNasterii;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(nume);
            sb.Append(" ");
            sb.Append(prenume);
            sb.Append("-");
            sb.Append(dataNasterii.ToShortDateString());

            return sb.ToString();
        }
        public int Age
        {
            get
            {
                DateTime azi = DateTime.Now;
                TimeSpan ts = azi.Subtract(dataNasterii);
                return ts.Days / 365;
            }
        }
    }
}