using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class exemplocontinue
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 51; i++)
            {
                if (i == 10)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

