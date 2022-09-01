using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3.Write a C# Sharp program to print the result of dividing two numbers. 
namespace ConsoleApp2
{
    internal class Class2
    {
        public static void Main3()
        {
            Console.WriteLine("Enter first number:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Quotient={a/b}");
            Console.ReadKey();

        }
    }
}
