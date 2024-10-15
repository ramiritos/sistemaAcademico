// C# usando Yi coder

using System;

class Program
{
    static void Main()
    {
        double[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Mean: " + CalculateMean(numbers));
        Console.WriteLine("Standard Deviation: " + CalculateStandardDeviation(numbers));
    }

    static double CalculateMean(double[] numbers)
    {
        return Array.Sum(numbers) / numbers.Length;
    }

    static double CalculateStandardDeviation(double[] numbers)
    {
        double mean = CalculateMean(numbers);
        double variance = (1.0 / numbers.Length) * Array.Sum(Array.ConvertAll(numbers, x => Math.Pow((x - mean), 2)));
        return Math.Sqrt(variance);
    }
}