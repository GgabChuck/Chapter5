using System;

namespace p151_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");

            string a = Console.ReadLine();
            int b = Int32.Parse(a);

            Console.WriteLine( b >= 50 ? $"입력하신 숫자 {a}는(은) 50 이상 입니다." : $"입력하신 숫자 {a}는(은) 50 미만 입니다.");
        }
    }
}
