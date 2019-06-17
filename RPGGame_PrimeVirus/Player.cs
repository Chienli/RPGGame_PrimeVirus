using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame_PrimeVirus
{
    public class Player
    {
        private Random rnd = new Random();
        public virtual int Hp { get; set; }

        public virtual string Job { get; set; }

        public virtual int MaxHp { get; set; }

        public string Name { get; set; }

        public virtual int Power { get; set; }

        public virtual void Attack(Player PPL)
        {
            PPL.Hp -= Power;
        }

        public virtual bool Run()
        {
            return !(rnd.Next(1, 11) <= 5); ;
        }

        public virtual void Skill(Player PPL)
        {
        }
    }
}