using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Write a C# Sharp program to print the sum of two numbers. 
namespace ConsoleApp2
{
    
    internal class Class1
    {
        public static void Main2()
        {   
            Console.WriteLine("Enter first number:");
            
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum={a + b}");
            Console.ReadKey();

        }
    }
}
