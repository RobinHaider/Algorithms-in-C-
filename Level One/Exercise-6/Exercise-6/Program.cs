using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        //Write a C# Sharp program to remove the character in a given position of a given string.

        static void Main(string[] args)
        {
            Console.WriteLine(removeWord("Extraordinary",0));
            Console.WriteLine(removeWord("Extraordinary",12));

            Console.ReadKey();
        }

        public static string removeWord(string word, int position)
        {
            return word.Remove(position, 1);
        }
    }
}
