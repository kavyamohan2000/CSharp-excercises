using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 
namespace ConsoleApp2
{
    internal class Class9
    {
        public static void Main()
        {
            Console.WriteLine("Input the first number:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number:");

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The result of the three specified numbers {a},{b} and {c} is: (x+y).z={(a + b) * c} and x.y + y.z is {a * b + b * c}");
            Console.ReadLine();


        }
    }
}
