using System;

namespace For
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                // 0 표출, 0은 5보다 작은 값이다(참),0출력, 0 + 1 = 1
                // 1은 5보다 작은 값이다(참),1출력, 1 + 1 = 2
                // 2은 5보다 작은 값이다(참),2출력, 2 + 1 = 3
                // 3은 5보다 작은 값이다(참),3출력, 3 + 1 = 4
                // 4은 5보다 작은 값이다(참),4출력, 4 + 1 = 5
                // 5는 5보다 작은 값이다(거짓)
            }
        }
    }
}
