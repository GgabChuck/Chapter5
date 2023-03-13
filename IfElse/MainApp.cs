using System;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine(); // 문자를 넣는다, 사용자가 적는것을
            int number = Int32.Parse(input); // int의 수는 정수(사용자가 적은 문자를 수로 변환 후)로 함

            if (number < 0)
            {
                Console.WriteLine("음수");
            }
            else if (number > 0)
            {
                Console.WriteLine("양수");
            }
            else
            {
                Console.WriteLine("0");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }

            string result = (number % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
            //Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
        }
    }
}
