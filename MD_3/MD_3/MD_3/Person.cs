using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD_3
{
    public class Person
    {
        //public Person()
        //{
        //    FirstName = firstname;

        //}


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public string Hobijs { get; set; }
        public string Dzimums { get; set; }

        public int Age()
        {
            return DateTime.Now.Year - BirthYear;
        }

        public void Hello()
        {
            Console.WriteLine($"Sveiki, mans vards ir {FirstName} {LastName} un man ir {Age()} gadi");
        }


    }
}
