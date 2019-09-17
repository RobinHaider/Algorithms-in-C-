using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        //Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

        static void Main(string[] args)
        {
            Console.WriteLine(test(10,50));
            Console.WriteLine(test(30,10));
            Console.WriteLine(test(20,30));
            Console.WriteLine(test(20,10));

            Console.ReadKey();
        }

        public static bool test(int a, int b)
        {
            return a == 30 || b == 30 || a + b == 30;
        }
    }
}
