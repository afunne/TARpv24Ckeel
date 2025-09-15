using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    internal class YOUWILLWORK
    {
        class Program2
        {
            static void Main()
            {
                double[] numbers = Text_numbers();

                AnalyzeNumbers(numbers);
            }

            // Function to get numbers from the user
            static double[] Text_numbers()
            {
                Console.WriteLine("Sisestage numbrid tühikutega eraldatuna: ");
                string input = Console.ReadLine();

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                double[] numbers = new double[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    numbers[i] = double.Parse(parts[i]);
                }

                return numbers;
            }

            // Function to analyze numbers
            static void AnalyzeNumbers(double[] numbers)
            {
                double max = numbers[0];
                double min = numbers[0];
                double sum = 0;

                foreach (double num in numbers)
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                    sum += num;
                }

                double avg = sum / numbers.Length;

                int greaterThanAvgCount = 0;
                foreach (double num in numbers)
                {
                    if (num > avg) greaterThanAvgCount++;
                }

                Console.WriteLine($"Maximum: {max}");
                Console.WriteLine($"Minimum: {min}");
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Keskmine: {avg}");
                Console.WriteLine($"Keskmisest suuremad arvud: {greaterThanAvgCount}");

                // Bonus: Output sorted numbers
                Array.Sort(numbers);
                Console.WriteLine("Numbrid järjekorras: " + string.Join(", ", numbers));
            }
        }
    }
}
