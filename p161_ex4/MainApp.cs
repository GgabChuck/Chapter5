using System;

namespace p161_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("알고싶은 월을 입력해주세요. : ");
            int a = Int32.Parse(Console.ReadLine());
            string b = "";

            switch (a)
            {
                case 3:
                case 4:
                case 5:
                    b = "봄";
                    break;
                case 6:
                case 7:
                case 8:
                    b = "여름";
                    break;
                case 9:
                case 10:
                case 11:
                    b = "가을";
                    break;
                case 12:
                case 1:
                case 2:
                    b = "겨울";
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 확인 후 다시 실행해 주세요.");
                    return;
            }
            Console.WriteLine($"입력하신 {a}월은 {b} 입니다.");
        }
    }
}
