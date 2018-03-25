//CONFIMED from TonyTroev
using System;

namespace _05_CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            // Read name ant stats of the game character:
            string character = Console.ReadLine();
            int currHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currenergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            // Print character's stats on the console:
            Console.WriteLine($"Name: {character}\n" +
                $"Health: |{new string('|', currHealth)}{new string('.', maxHealth - currHealth)}|\n" +
                $"Energy: |{new string('|', currenergy)}{new string('.', maxEnergy - currenergy)}|");
        }
    }
}
