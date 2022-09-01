using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//8.Write a C# Sharp program that takes a number as input and print its multiplication table. 
namespace ConsoleApp2
{
    internal class Class7
    {
        public static void Main8()
        {
            Console.WriteLine("Input the number:");

            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{a}*{i}={a * i}");
            }
            Console.ReadKey();
        }
    }
}
