using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray.CurrencyCalculator
{
    internal class CurrencyСalculation 
    {

  
        public void СalculateCurrency(string currency)
        {
            Console.Write("Введите сумму конверктрируемой валюты: ");

            decimal sum = Convert.ToDecimal(Console.ReadLine());
            decimal usdRf = 83.6m;
            decimal eurRf = 97.6m;

            if (currency == "usd" || currency == "доллар")
            {

                decimal calculateUsd = sum * usdRf;
                Console.WriteLine($"Перевод в рубли будет равен: {calculateUsd}");

            }
            else if (currency == "eur" || currency == "евро")
            {
                decimal calculateEur = sum * eurRf;
                Console.WriteLine($"Перевод в рубли будет равен: {calculateEur}");
            }



        }
    }
}
