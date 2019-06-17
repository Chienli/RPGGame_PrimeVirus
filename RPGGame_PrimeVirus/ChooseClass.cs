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
        public Player chooseClass()
        {
            while (true)
            {
                Console.WriteLine("type[Novice],[Warrior] or [Priest] to create your character");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "Novice":
                        return new Novice();
                    //break;

                    case "Warrior":
                        return new Warrior();
                    //break;

                    case "Priest":
                        return new Priest();
                    //break;

                    default:
                        continue;
                }

                break;
            }
        }
    }
}