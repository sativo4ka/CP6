using System;
using System.Collections.Generic;

namespace CP6 
{

    public class Program
    {
        public static void Main()
        {
            var testList = new List<string> { "10", "", "abc", "20" };
            int result = NumberParser.SumValidNumbers(testList);
            Console.WriteLine($"Итоговая сумма: {result}");
        }
    }
}