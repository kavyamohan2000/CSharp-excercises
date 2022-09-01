using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//6. Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 

namespace ConsoleApp2
{
    internal class Class5
    {
        public static void Main6()
        {
            Console.WriteLine("Input the first number to multiply:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply:");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply:");

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}*{b}*{c}={a * b * c}");
            Console.ReadKey();
        }
    }
}
