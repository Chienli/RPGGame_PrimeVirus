using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame_PrimeVirus
{
	internal class Player
	{
		public Player()
		{
			Console.WriteLine("Please enter your Name:");
		}

		public int Hp
		{
			get { return 100; }
			set { Hp = value; }
		}

		public string Name { get; set; }
	}
}