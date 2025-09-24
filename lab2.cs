using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray
{
    public class Lab2
    {

        /*Задача: напишите программу на C#, которая рассчитывает абсолютную разность между n и числом 48, 
         где n — это любое целое число. Если n больше 48, то верните тройную абсолютную разность */


        public static void GetAnsver2()
        {
            Console.Write("Введите число от 1 до 48 ");

            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {

                Console.WriteLine("Вы ввели чило 0, повторите ввод! ");
                Console.Write("Введите число от 1 до 48 ");
            }
            else if (num > 48)
            {
                Console.WriteLine("Вы ввели чило больше 48, вам вернется тройная сумма! ");
                Console.WriteLine($"Тройная абсалютная разность {num} = {Math.Abs(num)}");

            }

            num = Math.Abs(num);
            Console.WriteLine(num);

            Console.ReadKey();
        }
            
    }

    
}
