using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Diego Carmona
 * Course: Comp-003A
 * Purpose: To gain a higher understanding of methods within C# coding.
 */

namespace COMP003A.LectureActivity5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("Methods & XML Comments");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("\n");

            HelloWorld(); // call to HelloWorld()
            HelloWorld("Grace Hopper"); // call to HelloWorld(string name)
            HelloWorld("Donald Knuth"); // call to HelloWorld(string name) again with a differnt parameter value
            HelloWorld("Alan Turing", DateTime.Now.Year - 1912); // call to HelloWorld(string name, int inputAge), which is an overloaded method
            HelloWorld("Ada Lovelace", DateTime.Now.Year - 1815); // call to HelloWorld(string name, int inputAge) again
            HelloWorld("Charles Babbage", DateTime.Now.Year - 1791); // call to HelloWorld(string name, int inputAge) again
        }
    }
}
