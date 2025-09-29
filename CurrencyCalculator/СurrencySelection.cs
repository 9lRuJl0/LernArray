using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray.CurrencyCalculator
{
    internal class СurrencySelection
    {


        public string SelectedCurrency()
        {



            Console.Write("Выберите валюту Доллар или Евро: ");
            //string work = "";
            string currency = Console.ReadLine().ToLower();
            {
                switch (currency)
                {

                    case "usd":
                    case "доллар":
                        Console.WriteLine("Вы выбрали Доллар США! На сегодня курс равен = 83,6 рублей за 1$ ");
                        break;

                    case "eur":
                    case "евро":
                        Console.WriteLine("Вы выбрали Евро! На сегодня курс равен = 97,6 рублей за 1€ ");
                        break;

                    default:
                        break;

                }

                return currency;


                /*while (work != "Y")
                {
                    Console.Write("Попробуете еще раз? Чтобы продолжить нажмите Y, закончить нажмите Q - ");
                    work = Console.ReadLine().ToLower();
                    switch (work)
                    {
                        case "y":
                            Console.Write("Выберите валюту Доллар или Евро: ");
                            break;

                        case "q":
                            Console.Write("Вы выбрали завершение программы");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.Write("Вы ввели некорректные данные, пожалуйста повторите ввод");
                            break;
                    } */

            Console.ReadKey();

            }

            





            
        }
    }
}
