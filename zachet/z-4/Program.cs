using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();

            myAddress.Index = "1000";
            myAddress.Country = "PMR";
            myAddress.City = "Tiraspol";
            myAddress.Street = "Mira 50";
            myAddress.House = "20";
            myAddress.Apartment = "4";

            Console.WriteLine("Index: " + myAddress.Index);
            Console.WriteLine("Country: " + myAddress.Country);
            Console.WriteLine("City: " + myAddress.City);
            Console.WriteLine("Street: " + myAddress.Street);
            Console.WriteLine("House: " + myAddress.House);
            Console.WriteLine("Apartment: " + myAddress.Apartment);

            Console.ReadLine();
        }
    }
}
