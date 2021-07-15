using System;
using System.Globalization;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Vladik's mam");
            int lol = 228;
            string kek = ("Keks");
            decimal b = 5.5m;
            Console.WriteLine(lol);
            Console.WriteLine(kek);
            Console.WriteLine(b);
            string str1 = "some string and ";
            string str2 = "some string #2";
            string str3 = str1 + str2;
            const double PI = 3.14;
            Console.WriteLine(str3);
            Console.WriteLine(PI);
            Console.WriteLine(Math.PI);
            sbyte a = 15;
            int b2 = a;
            Console.WriteLine(b2);
            string str = "1000";
            short x = Convert.ToInt16(str);
            Console.WriteLine(x);
            Console.WriteLine("Input number:");
            string y = Console.ReadLine();
            int z = Convert.ToInt32(y);
            z = z * z;
            if(z >= 0  )
            {
                Console.WriteLine(z);
            }
            else
            {
                Console.WriteLine("Are you idiot?");
            }
            Console.WriteLine("Input number:");
            string text = Console.ReadLine();
            int xxx = Convert.ToInt32(text);
            string result = xxx > 100 ? "more than 100" : "less than 100";
            Console.WriteLine("Result: " + result);
            Console.WriteLine("Input number again:");
            string text2 = Console.ReadLine();
            int x_x = Convert.ToInt32(text2);
            switch (x_x)
            {
                case 1:
                    Console.WriteLine("Number 1");
                    break;
                case 2:
                    Console.WriteLine("Number 2");
                    break;
                case 3:
                    Console.WriteLine("Number 3");
                    break;
                default:
                    Console.WriteLine("You entered a large number!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
