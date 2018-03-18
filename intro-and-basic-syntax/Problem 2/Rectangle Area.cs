using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
		//Write a program, which calculates a rectangle’s area, based on its width and height. 
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a*b:f2}");
        }
    }
}