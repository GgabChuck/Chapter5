using System;

namespace KimGiBoem_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입려하세요 : ");
            int a = Int32.Parse(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
            }

            for (int b = 0; b < a; b++)
            {
                for (int c = 0; c <= b; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
