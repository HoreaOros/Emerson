using System;

namespace Clase
{
    internal class Motor
    {
        private int nrCilindri;
        private int CP;
        private Combustibil combustibil;
        private int turatie;
        private readonly int TuratieMaxima = 6000;

        public int Turatie
        {
            get
            {
                return turatie;
            }

            internal set
            {
                if (value >= 0 && value <= TuratieMaxima)
                {
                    turatie = value;
                }
                else
                    throw new TuratieNotAllowedException("Turatia nu e in limitele acceptate");
            }
        }

        public Motor(int nrCilindri, int CP, Combustibil combustibil)
        {
            this.nrCilindri = nrCilindri;
            this.CP = CP;
            this.combustibil = combustibil;
            turatie = 0;
        }

        internal void Stop()
        {
            turatie = 0;
        }

        public override string ToString()
        {
            return string.Format("[Numar cilindri: {0}, CP: {1}, Combustibil: {2}]",
                nrCilindri, CP, combustibil);
        }

        public void Start()
        {
            turatie = 1000;
        }
    }

    enum Combustibil
    {
        Benzina,
        Diesel
    }
}