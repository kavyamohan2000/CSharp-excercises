using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//9. Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
namespace ConsoleApp2
{
    internal class Class8
    {
        public static void Main9()
        {
            Console.WriteLine("Input the first number:");

            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number:");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the third number:");

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the fourth number:");

            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The average of {a},{b},{c} and {d} is {(a + b + c + d) / 4}");
            Console.ReadKey();
        }
    }
}
