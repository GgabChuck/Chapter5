using System;

namespace p151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요. : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요. : ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요. : ");
            int c = Int32.Parse(Console.ReadLine());
            int max = 0;
            int min = 0;
            int plus = a + b + c;
            int d = plus / 3;

            if (a >= b && a >= c)
            {
                max = a;
                if (b <= c)
                {
                    min = b;
                }
                else
                {
                    min = c;
                }
            }
            else if (b >= a && b >= c)
            {
                max = b;
                if (a <= c)
                {
                    min = a;
                }
                else
                {
                    min = c;
                }
            }
            else
                max = c;
            {
                if (a <= b)
                {
                    min = a;
                }
                else
                {
                    min = b;
                }
            }
            Console.WriteLine($"입력하신 {a},{b},{c} 중 최대값은 {max}이며, 최소값은 {min} 입니다.");
            Console.WriteLine($"입력하신 {a},{b},{c} 의 합은 {plus}이며, 평균은 {d} 입니다.");
        }
    }
}
