using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Den";
           // FirstName = "Den";

            string LastName = "Shitov";
            //LastName = "Shitov";

            string Country = "Russia";
            //Country = "Russia";

            string zipCode = "344022";
            //zipCode = "344022";

            string City = "Rostov on Don";
            //City = "Rostov on Don";

            string streetAddress = "Juravlev st. 100";
            //streetAddress = "Juravlev st. 100";

            Console.WriteLine("First Name:  {0}" ,FirstName);
            Console.WriteLine("Lastname: {0}", LastName); 
            Console.WriteLine("Country: "+ Country);
            Console.WriteLine("City: "+ City);
            Console.WriteLine("Zip Code : "+ zipCode);
            Console.WriteLine("Street address: "+ streetAddress);
            Console.ReadLine();
        }
    }
}
