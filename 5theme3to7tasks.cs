using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv24Ckeel
{
    internal class _5theme3to7tasks
        // thanks to you stack overflow i did this task <3
    {
        public class õpilane
        {
            public string Name { get; set; }
            public List<int> Grades { get; set; }

            // Constructor
            public õpilane(string name, List<int> grades)
            {
                Name = name;
                Grades = grades;
            }

            // Method to calculate the average grade
            public double CalculateAverageGrade()
            {
                if (Grades == null || Grades.Count == 0)
                {
                    return 0.0; // Handle cases with no grades
                }
                return Grades.Average(); // Uses LINQ's Average() method
            }
        }

        public class Program
        {
            public static void Main(string[] args)
            {
                // 2. Create at least 3 students with their grades
                õpilane student1 = new õpilane("Bobich Clankerich", new List<int> { 5, 3, 4, 4 });
                õpilane student2 = new õpilane("Kriss Skidatels", new List<int> { 4, 4, 3 });
                õpilane student3 = new õpilane("Martin Que", new List<int> { 3, 3, 3, 3, 3 });
                õpilane student4 = new õpilane("Blut Britanovits", new List<int> { 3, 4, 5 });


                // Store all students in a list
                List<õpilane> students = new List<õpilane> { student1, student2, student3, student4 };

                // Variables to track the highest average and the corresponding student
                double highestAverage = -1.0;
                õpilane topStudent = null;

                // 3. Iterate through students, calculate average, and find the highest
                Console.WriteLine("Student Averages:");
                foreach (var student in students)
                {
                    double average = student.CalculateAverageGrade();
                    Console.WriteLine($"{student.Name}: {average:F2}"); // Format to 2 decimal places

                    if (average > highestAverage)
                    {
                        highestAverage = average;
                        topStudent = student;
                    }
                }

                // 4. Output the student with the highest average
                if (topStudent != null)
                {
                    Console.WriteLine($"\nKõrgeima keskmise hindega õpilane on: {topStudent.Name} (Keskmine: {highestAverage:F2})");
                }
                else
                {
                    Console.WriteLine("\nÜhtegi õpilase andmeid ei sisestatud ega töödeldud.");
                }

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

            // harjutus 2
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
}