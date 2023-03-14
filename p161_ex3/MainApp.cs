using System;

namespace p161_ex3
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("몇월이 궁금하세요? : ");
            int a = Int32.Parse(Console.ReadLine());
            int b = 0;

            switch (a)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    b = 31;
                    break;
                case 2:
                    b = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    b = 30;
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다.다시 실행하여 주세요.");
                    return;
            }
            Console.WriteLine($"{a}월은 {b}일까지 있습니다.");
        }
    }
}
