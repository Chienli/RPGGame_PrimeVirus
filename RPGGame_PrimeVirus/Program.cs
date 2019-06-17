using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame_PrimeVirus
{
    internal class Program
    {
        private static ChooseClass chooseClass = new ChooseClass();

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello Hero , Welcome to SHIN INTERN MUSOU");

            Console.WriteLine("Please enter your Name:");
            var name = Console.ReadLine();

            var player = chooseClass.chooseClass();
            player.Name = name;

            Console.WriteLine($"hi {player.Job} {player.Name}.");

            var monster = new Monster();

            Console.WriteLine($"There is a {monster.Job},kill it.");

            Fight.fight(player, monster);
        }
    }
}