using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame_PrimeVirus
{
    internal class ChooseClass
    {
        public void chooseClass(int x)
        {
            Console.WriteLine("type[Novice],[Warrior] or [Priest] to create your character");
            var input = Console.ReadLine();
            string[] job = { "Novice", "Warrior", "Priest" };
            switch (input)
            {
                case "Novice": break;
                case "Warrior": break;
                case "Priest": break;
            }
        }
    }
}