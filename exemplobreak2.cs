using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class exemplobreak2
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i == 11)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
