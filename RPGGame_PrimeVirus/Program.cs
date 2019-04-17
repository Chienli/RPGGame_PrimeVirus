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
			var player = new Player();
			Console.WriteLine("Please enter your Name:");
			player.Name = Console.ReadLine();
			chooseClass.chooseClass(player);
			Console.WriteLine($"hi {player.Name} , {player.Job} ");
			Console.ReadLine();
		}
	}
}