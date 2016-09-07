using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorModel calculatorModel = new CalculatorModel();
            Console.WriteLine("Please enter your date of birth (dd-mm-yyyy) to calculate your age.");
            
            DateTime dT;
            if (calculatorModel.ParseInput(Console.ReadLine(), out dT))
            {
                int age = calculatorModel.CalculateAge(dT);
                Console.WriteLine("Your age is calculated to be: " + age);
            }
            else
            {
                Console.WriteLine("Input is invalid.");
            }
            
            Console.ReadLine();
        }
    }
}
