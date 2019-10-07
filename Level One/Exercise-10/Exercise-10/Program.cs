using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        //Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7
        static void Main(string[] args)
        {
            Console.WriteLine(Test(10));
            Console.WriteLine(Test(18));
            Console.WriteLine(Test(21));
            Console.WriteLine(Test(25));
            Console.ReadKey();
        }

        public static bool Test(int a)
        {
            return a % 3 == 0 || a % 7 == 0;
        }
    }
}
