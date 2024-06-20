using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class matrizes4
    {
        static void Main(string[] args)
        {
            // Declare an array
            string[] cars;

            // Add values, using new
            cars = new string[] { "Volvo", "BMW", "Ford" };

            // This would cause an error: cars = {"Volvo", "BMW", "Ford"};

            Console.WriteLine(cars[0]);
        }
    }
}