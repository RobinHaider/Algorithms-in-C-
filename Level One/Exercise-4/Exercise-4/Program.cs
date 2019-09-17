using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        //check a given integer and return true if it is within 10 of 100 or 200
        static void Main(string[] args)
        {
            Console.WriteLine("check a given integer and return true if it is within 10 of 100 or 200");
            Console.WriteLine(test(95));
            Console.WriteLine(test(99));
            Console.WriteLine(test(110));
            Console.WriteLine(test(200));
            Console.WriteLine(test(88));

            Console.ReadKey();
        }

        public static bool test(int a)
        {
            //Math.abs substrat minValue form MaxValue
            if (Math.Abs(a - 100) <= 10 || Math.Abs(a - 200) <= 10)
            {
                return true;
            }

            return false;
        }
    }
}
