﻿using System;

namespace KimGiBoem_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a < 5)
            {
                int b = 0;
                while (b <= a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}
