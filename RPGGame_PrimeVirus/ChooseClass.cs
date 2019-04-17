using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace RPGGame_PrimeVirus
{
    internal class ChooseClass
    {
        public void chooseClass(Player player)
        {
            Console.WriteLine("type[Novice],[Warrior] or [Priest] to create your character");
            var input = Console.ReadLine();
            string[] job = { "Novice", "Warrior", "Priest" };
            switch (input)
            {
                case "Novice":
                    player = new Novice(); break;
                case "Warrior":
                    player = new Warrior(); break;
                case "Priest":
                    player = new Priest(); break;
            }
        }
    }
}