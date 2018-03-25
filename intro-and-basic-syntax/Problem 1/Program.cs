//CONFIRMED from TonyTroev
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input from the console:
            var firstFourNums = int.Parse(Console.ReadLine());
            var secondFourNums = int.Parse(Console.ReadLine());
            var thirdFourNums = int.Parse(Console.ReadLine());
            var fourthFourNums = int.Parse(Console.ReadLine());

            // Print every number, that you recently reade from the console in special 4-digit debit card format:
            Console.WriteLine($"{firstFourNums:d4} {secondFourNums:d4} {thirdFourNums:d4} {fourthFourNums:d4}");

        }
    }
}

    

