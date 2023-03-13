using System;

namespace p151_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("정수 한 개를 입력하세요. : ");

            string a = Console.ReadLine();
            int b = Int32.Parse(a);

            if (b % 3 == 0)
                Console.WriteLine($"입력하신 정수{a}은(는) 3의 배수 입니다.");
            else
                Console.WriteLine($"입력하신 정수{a}은(는) 3의 배수가 아닙니다.");
                
        }
    }
}
