using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.

        static void Main(string[] args)
        {
            Console.WriteLine(SwapLetter("Raheel"));
            Console.WriteLine(SwapLetter("ABCD"));
            Console.WriteLine(SwapLetter("a"));
            Console.ReadKey();
        }


        public static string SwapLetter(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
                : str;
        }
    }
}
