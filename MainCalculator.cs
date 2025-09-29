using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray
{
    internal static class MainCalculator
    {

         public static void Execute()
        {
            var calculator = new Calculator(1000000m);

            decimal result = 0;
            for (int i = 0; i < 11; i++)
            {
                result = calculator.Calculate();
            }
            Console.WriteLine($"Моя зарплата равна {result}");



        }

    }
}
