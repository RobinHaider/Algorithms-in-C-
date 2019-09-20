using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        //Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.

        static void Main(string[] args)
        {
            Console.WriteLine(test("If you are"));
            Console.WriteLine(test("if whatever"));
            Console.WriteLine(test("whatever"));

            Console.ReadKey();
        }

        public static string test(string sentence)
        {
            if (sentence.Substring(0, 2).ToLower().Equals("if"))
            {
                return sentence;
            }

            return "If " + sentence;
        }
    }
}
