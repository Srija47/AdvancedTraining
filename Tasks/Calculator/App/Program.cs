using System;
using Calculate;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display title as the C# console calculator app.
            Console.WriteLine("Welcome to Console Calculator.\n");

             // Declare variables and Ask the User to enter inputs.
                double input_1 =Convert.ToDouble(Console.ReadLine());
                double input_2 = Convert.ToDouble(Console.ReadLine());
                
                // Ask the user to enter an operator.
                Console.WriteLine("Enter an operator:");
                string op=Console.ReadLine();

                var cal = new DoCalculate();

                Console.WriteLine(cal.DoOperation(input_1,input_2,op));
        }
    }
}
