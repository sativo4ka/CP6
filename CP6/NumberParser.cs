using System;
using System.Collections.Generic;
using System.Text;

namespace CP6
{
    public class NumberParser
    {
        public static int SumValidNumbers(List<string> values)
        {
            int sum = 0;
            int processedCount = 0;

            if (values == null)
                return sum;

            foreach (var value in values)
            {
                try
                {
                    int number = int.Parse(value);
                    sum += number;
                }
                catch (FormatException) when (string.IsNullOrWhiteSpace(value))
                {
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"[Предупреждение] Ошибка формата '{value}': {ex.Message}");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"[Ошибка] Переполнение при парсинге '{value}'");
                    throw;
                }
                finally
                {
                    processedCount++;
                    Console.WriteLine($"Обработано элементов: {processedCount}");
                }
            }

            return sum;
        }
    }
}
