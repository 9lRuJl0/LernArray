using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LernArray
{
    public class LernArray
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator(0m);

            decimal result = calculator.Calculate(500000);

            Console.WriteLine($"Моя зарплата равна {result}");

            
        }
    }

    
}








