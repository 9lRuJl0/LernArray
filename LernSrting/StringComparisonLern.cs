using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LernArray.LernSrting
{
    internal class StringComparisonLern
    {


    

     public static void StringEqualitySpecifyingCompareRules()
        {
            string s1 = "Hello!";
            string s2 = "HELLO!";

            Console.WriteLine("s1 = {0}", s1);
            Console.WriteLine("s2 = {0}", s2);
            Console.WriteLine();

            // Сравнение строк
            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.Equals(s2): {2}", s1, s2, s1.Equals(s2));
            Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));

            Console.WriteLine();
            Console.WriteLine("Default rules: s1={0}, s2={1}, s1.IndexOf(\"E\"): {2}", s1, s2, s1.IndexOf("E"));
            Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase): {0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
        }
    }

}
