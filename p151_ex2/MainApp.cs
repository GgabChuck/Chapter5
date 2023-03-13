using System;

namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number >= 70)
            {
                if (number >= 90)
                {
                    Console.WriteLine($"입력하신 점수 {input}는(은) A 학점 입니다.");
                }
                else if (number >= 80)
                {
                    Console.WriteLine($"입력하신 점수 {input}는(은) B 학점 입니다.");
                }
                else
                {
                    Console.WriteLine($"입력하신 점수 {input}는(은) c 학점 입니다.");
                }
            }
            else
            {
                Console.WriteLine($"입력하신 점수 {input}는(은) F 학점 입니다.");
            }
        }
    }
}
