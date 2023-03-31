using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimGiBoem_ex3_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 5;

            do
            {
                int b = 0;
                while (b < a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a--;
            }
            while (a > 0);
        }
    }
}
