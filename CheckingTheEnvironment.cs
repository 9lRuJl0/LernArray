using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray
{
    internal class CheckingTheEnvironment
    {

        public static void ShowEnvironmentDetails()
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


    }
}
