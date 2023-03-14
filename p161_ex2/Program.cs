using System;

namespace p161_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요!");
            Console.Write("첫 번째 정수를 입력해주세요. : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("두 번째 정수를 입력해주세요. : ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("연산기호를 입력해주세요. ex)+,-,*,/,% :");
            string c = Console.ReadLine();

            int d = 0;

            switch (c)
            {
                case "+":
                    d = a + b;
                    break;
                case "-":
                    d = a - b;
                    break;
                case "*":
                    d = a * b;
                    break;
                case "/":
                    d = a / b;
                    break;
                case "%":
                    d = a % b;
                    break;
                default:
                    Console.WriteLine("입력하신 연산기호는 잘못되었습니다.");
                    return;

            }

            Console.WriteLine($"입력하신 {a}{c}{b}의 결과값은 {d} 입니다.");
        }
    }
}
