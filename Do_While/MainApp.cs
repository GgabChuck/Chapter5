using System;

namespace Do_While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);
            //a) i : 10
            //a) i : 9
            //a) i : 8
            //a) i : 7
            //a) i : 6
            //a) i : 5
            //a) i : 4
            //a) i : 3
            //a) i : 2
            //a) i : 1
            do
            {
                Console.WriteLine("b) i : {0}", i--);
            }
            //b) i : 0
            while (i > 0);
        }
    }
}
