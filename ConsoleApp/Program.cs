using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Please enter a number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Thank you.  Please enter another: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The sume of the two numbers: " + (number1 + number2));

            Console.ReadLine();
        }
    }
}
