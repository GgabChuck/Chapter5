using System;

namespace p151_ex6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요.(ex.2) : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("현재 본인의 점수를 입력해 주세요.(ex.85) : ");
            int b = Int32.Parse(Console.ReadLine());

            if (a >= 1 && a <= 3)
            {
                if (b >= 60 && b <= 100)
                {
                    Console.WriteLine($"입력하신 점수 {b}는(은) 합격입니다.");
                }
                else if (b < 60 && b >= 0)
                {
                    Console.WriteLine($"입력하신 점수 {b}는(은) 불합격입니다.");
                }
                else
                {
                    Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
                }
            }
            else if (a == 4)
            {
                if (b >= 70 && b <= 100)
                {
                    Console.WriteLine($"입력하신 점수 {b}는(은) 합격입니다.");
                }
                else if (b < 70 && b >= 0)
                {
                    Console.WriteLine($"입력하신 점수 {b}는(은) 불합격입니다.");
                }
                else
                {
                    Console.WriteLine("점수를 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
                }
            }
            else
            {
                Console.WriteLine("학년을 잘못입력하셨습니다. 확인 후 다시 입력해주세요.");
            }
        }
    }
}
