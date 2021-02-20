using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Module 1 Assignment");

            int myVariable1 = 1;
            int myVariable2 = 3;

            Console.WriteLine(myVariable1);
            Console.WriteLine(myVariable2);

            Console.WriteLine(myVariable1 * myVariable2);
            Console.WriteLine("Multiplication then Division");

            Console.WriteLine(myVariable1 / myVariable2);
            string myVariablestring = ("I think I have done a good job?");

            Console.WriteLine(myVariablestring);
        }

        public static void AMethod()
        {
            //something here
        }
    }
}