using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7.Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
namespace ConsoleApp2
{
    internal class Class6
    {
        public static void Main7()
        {
            Console.WriteLine("Input the first number:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}*{b}={a * b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}/{b}={a / b}");
            Console.WriteLine($"{a}%{b}={a % b}");
            Console.ReadKey();
        }
    }
}
