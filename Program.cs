using System;





namespace LernArray
{
    public class LernArray
    {
        static void Main(string[] args)
        {

            var calculator = new Calculator(1000000m);
  
            decimal result = 0;
            for (int i = 0; i < 11; i++)
            {             
                result = calculator.Calculate();
            }
            Console.WriteLine($"Моя зарплата равна {result}");





            /* static void ShowEnvironmentDetails()
             {
                 // Вывести информацию о дисковых устройствах
                 // данной машины и другие интересные детали.
                 foreach (string drive in Environment.GetLogicalDrives())
                 {
                     Console.WriteLine("Drive: {0}", drive); // Логические устройства
                 }
                 Console.WriteLine("OS: {0}", Environment.OSVersion);
                 // Версия операционной системы
                 Console.WriteLine("Number of processors: {0}",
                 Environment.ProcessorCount);
                 Console.WriteLine(".NET Core Version: {0}",
                 Environment.Version);
                 // Количество процессоров
                 // Версия платформы .NET Core
             }

             ShowEnvironmentDetails();*/
            Console.ReadLine();
        }





    }

}


