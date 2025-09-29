using LernArray.CurrencyCalculator;
using LernArray.LernSrting;
using System;
using System.Net;
using System.Text.RegularExpressions;





namespace LernArray
{
    public class LernArray
    {
        static void Main(string[] args)
        {

            //MainCalculator.Execute();
            // CheckingTheEnvironment.ShowEnvironmentDetails();
            // Lab2.GetAnsver2();
            //StringComparisonLern.StringEqualitySpecifyingCompareRules();



            СurrencySelection cs = new СurrencySelection();

            string currency = cs.SelectedCurrency();

            CurrencyСalculation cc = new CurrencyСalculation();
            cc.СalculateCurrency(currency);

            Console.ReadKey();
        }

    }
}



    



