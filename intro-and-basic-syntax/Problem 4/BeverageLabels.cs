//CONFIRMED from TonyTroev
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
		    // Read product's name, volume and energy and sugar content per 100ml:
            var name = Console.ReadLine();
            var vol = int.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var sugar = double.Parse(Console.ReadLine());

            // Calculate actual energy and sugar for the current product's volume:
            var actualEnergy = energy / 100 * vol;
            var actualSugar = sugar / 100 * vol;

            // Print the result:
            Console.WriteLine("{0}ml {1}:", vol, name);
            Console.WriteLine("{0}kcal, {2}g sugars", actualEnergy, actualSugar, gram, sug);
        }
    }
}
