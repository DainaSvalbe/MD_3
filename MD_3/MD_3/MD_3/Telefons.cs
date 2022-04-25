using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    public class Telefons
    {

        public string Marka { get; set; }

        public string Modelis { get; set; }

        public int IzmersX { get; set; }

        public int IzmersY { get; set; }

        public int IzmersZ { get; set; }


        public void Call()
        {
            Console.WriteLine("Calling");
        }

        public void Sms()
        {
            Console.WriteLine("Send SMS");
        }
    }
}
