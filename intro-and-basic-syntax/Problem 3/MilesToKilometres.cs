﻿using System;

namespace MilesToKilometres
{
    class MilesToKilometres
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{double.Parse(Console.ReadLine()) * 1.60934:F2}");
        }
    }
}
