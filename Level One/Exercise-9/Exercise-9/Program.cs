using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        //Write a C# Sharp program to create  a new string with the last char added at the front and back of a given string of length 1 or more
        static void Main(string[] args)
        {
            Console.WriteLine(Test("Robin"));
            Console.WriteLine(Test("Raheel"));
            Console.WriteLine(Test("B"));
            Console.ReadKey();
        }

        public static string Test(string str)
        {
            var s = str.Substring(0, 1);
            return s + str + s;
        }
    }
}
