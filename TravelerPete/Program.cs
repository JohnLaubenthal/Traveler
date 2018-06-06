using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerPete
{
    class Program
    {
        static void Main(string[] args)
        {
            CruiseShip pete = new CruiseShip();

            Console.WriteLine("Please enter your best friends age to choose a cruise ship.");
            pete.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("You have picked {0} cruise line", pete.GetCruiseShip());
        }
    }
}
