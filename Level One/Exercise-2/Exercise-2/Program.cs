using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
            Console.WriteLine(test(50));
            Console.WriteLine(test(19));
            Console.WriteLine(test(51));

            Console.ReadKey();
        }

        public static int test(int n)
        {
            const int x = 51;

            if (n > x)
            {
                return (n - x) * 3;
            }

            return x - n;
        }
    }
}
