using System;

namespace KimGiBoem_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 15;

            do
            {
                Console.Write("*");
                a -= 1;
            }
            while (a > 10);

            Console.WriteLine("");

            do
            {
                Console.Write("*");
                a -= 1;
            }
            while (a > 6);

            Console.WriteLine("");

            do
            {
                Console.Write("*");
                a -= 1;
            }
            while (a > 3);

            Console.WriteLine("");

            do
            {
                Console.Write("*");
                a -= 1;
            }
            while (a > 1);

            Console.WriteLine("");

            do
            {
                Console.Write("*");
                a -= 1;
            }
            while (a > 0);

            Console.WriteLine("");
        }
    }
}
