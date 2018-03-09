using System;

namespace MilesToKilometres
{
    class MilesToKilometres
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine($"{input * 1.60934:F2}");
        }
    }
}
