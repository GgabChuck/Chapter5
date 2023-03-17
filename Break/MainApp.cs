using System;

namespace Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속할까요?(예/아니오) : ");
                string a = Console.ReadLine();

                if (a == "아니오")
                {
                    break;
                }
            }
        }
    }
}
