using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray.LernSrting
{
    internal class ImmutableString
    {
        public static void StringsArelmmutable()
        {
            Console.WriteLine("=> Immutable Strings:\a");
            // Установить начальное значение для строки,
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);
            // Преобразована ли строка si в верхний регистр?
            string upperstring = s1.ToUpper();
            Console.WriteLine("upperstring = {0}", upperstring);
            // Нет! Строка si осталась в том же виде!
            Console.WriteLine("s1 = {0}", s1);
        }

         public static void StringsAreImmutable2()
        {
            Console.WriteLine("=> Immutable Strings 2:\a");
            string s2 = "My other string";
            s2 = "New string value";
        }
    }
}
