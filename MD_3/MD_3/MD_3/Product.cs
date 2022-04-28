using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    public class Product
    {
        public Product(double gar, double plat, double augst)
        {
            Gar = gar;
            Plat = plat;
            Augst = augst;

        }
        public double Gar
        { get; }
        public double Plat
        { get; }
        public double Augst
        { get; }

        public double Svars
        { get; set; }

        public void Izveidot()
        {
            //Gar = 10;
            //Plat = 20;
            //Augst = 30;
            Console.WriteLine("Pasuutijuma pakas izmeers");
        }

        public double XYZpaka()
        {
           Console.WriteLine($"X= {Gar}; Y= {Plat}; Z= {Augst} ");
            return Gar;
            return Plat;
            return Augst;

        }
    }
}
