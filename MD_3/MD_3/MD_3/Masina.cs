using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    public class Masina
    {
        public string Brand { get; set; }

        public string Number { get; set; }

        public double Speed { get; set; }

        public void StartDrive()
        {
            Speed = 10;
            Console.WriteLine("Saakam braukt");

        }

        public double Accelerate()
        {
            Speed += 10;
            //return Speed;
            Console.WriteLine($"Paatrinaas {Speed}");
            return Speed;

        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Apstaaties");
        }
        public void Beep()
        {
            Console.WriteLine("Beep beep");
        }

    }
}
