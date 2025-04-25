
using System;

namespace MyApplication
{
    class calculator
    {
 static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
        {
            total = 0;

            foreach (double num in numbers)
            {
                total += num;
            }

            average = numbers.Length > 0 ? total / numbers.Length : 0;
        }

    static void Main(string[] args)
    {
        // Prompting for user input
        Console.Write("Enter the first number: ");
        double Num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double Num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double Num3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the fourth number: ");
        double Num4 = Convert.ToDouble(Console.ReadLine());

        // Call the method with out parameters
        CalculateTotalAndAverage(out double total, out double average, Num1, Num2, Num3, Num4);

        // Output the result
        Console.WriteLine($"\nThe average of {Num1}, {Num2}, {Num3}, {Num4} is: {average:F2}");
        Console.WriteLine($"The total is {total}");
    }
}
}