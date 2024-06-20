using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class carros    
    {
       public static void Main(string[] args)
        {
            string[] cars = { "volvo", "bmw", "ford", "mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            
        }
    }
}
