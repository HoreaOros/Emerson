using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Clase
{
    class Vehicul
    {
        private string marca;
        private string model;
        private int anFabricatie;
        private Motor motor;
        private bool started;
        private int gear;

        public Vehicul(string marca, string model, int anFabricatie, Motor motor)
        {
            this.marca = marca;
            this.model = model;
            this.anFabricatie = anFabricatie;
            this.motor = motor;
            started = false;
            gear = 0;
        }

        public void Status()
        {
            Debug.WriteLine("Engine status: {0}, Gear: {1}, RPM: {2}", started ? "Started" : "Stoped", gear, motor.Turatie);
            //Console.WriteLine("Engine status: {0}, Gear: {1}, RPM: {2}", started?"Started":"Stoped", gear, motor.Turatie);
        }

        public void Stop()
        {
            motor.Stop();
            started = false;
        }

        public void Accelerate()
        {
            motor.Turatie = motor.Turatie + 100;

            // motor.Turatie = 10000; -100
        }

        public void ChangeGear(int v)
        {
            gear = v;
        }

        public void Start()
        {
            motor.Start();
            started = true;
            
        }

        public override string ToString()
        {
            return string.Format("Marca: {0}\nModel: {1}\nAn fabricatie: {2}\nMotor: {3}",
                marca, model, anFabricatie, motor);
        }
    }
}
