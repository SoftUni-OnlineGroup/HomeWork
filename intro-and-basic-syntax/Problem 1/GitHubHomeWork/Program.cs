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
            var firstFourNums = int.Parse(Console.ReadLine());
            var secondFourNums = int.Parse(Console.ReadLine());
            var thirdFourNums = int.Parse(Console.ReadLine());
            var fourthFourNums = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstFourNums:d4} {secondFourNums:d4} {thirdFourNums:d4} {fourthFourNums:d4}");

        }
    }
}

    

