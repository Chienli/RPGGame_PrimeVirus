using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame_PrimeVirus
{
	public class Player
	{
		public int Hp
		{
			get => 100;
			set => Hp = value;
		}

		public string Job
		{
			get => "GOBLIN";
			set => Job = value;
		}

		public string Name { get; set; }

		public int Power
		{
			get => 20;
			set => Power = value;
		}
	}
}