using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//5.Write a C# Sharp program to swap two numbers. 
namespace ConsoleApp2
{
    internal class Class4
    {
        public static void Main5()
        {
            Console.WriteLine("Enter first number:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");

            int b = Convert.ToInt32(Console.ReadLine());
            int t = a;
            a = b;
            b = t;
            Console.WriteLine("After swapping:");
            Console.WriteLine($"First number: {a}");
            Console.WriteLine($"Second number: {b}");
            Console.ReadKey();
        }
    }
}
