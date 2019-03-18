using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope
{
    class Program
    {   
        //this field on the program class can be access from all the methods of this class
        private static string helloClass = "Hello, class";

        static void Main(string[] args)
        {
            //this variable cannot be accessed outside of this method
            string helloLocal = "Hello, local variable!";
            Console.WriteLine(helloLocal);
            Console.WriteLine(Program.helloClass);
            AndAction();
        }

        static void AndAction()
        {
            Console.WriteLine("A message from AndAction: " + Program.helloClass);
            Console.ReadLine();
        }
    }
}
