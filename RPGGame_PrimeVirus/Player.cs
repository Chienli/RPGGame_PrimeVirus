using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame_PrimeVirus
{
    public class Player
    {
        public Player()
        {
            Console.WriteLine("Please enter your Name:");
            Name = Console.ReadLine();
        }

        public int Hp
        {
            get => 100;
            set => Hp = value;
        }

        public string Name { get; set; }

        public int Power
        {
            get => 20;
            set => Power = value;
        }
    }
}