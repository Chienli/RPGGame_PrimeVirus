using System;

namespace RPGGame_PrimeVirus
{
    public class Warrior : Player
    {
        public Warrior()
        {
            Hp = 80;
            MaxHp = 80;
            Job = "Warrior";
            Power = 30;
        }

        public override void Attack(Player PPL)
        {
            base.Attack(PPL);
            Console.WriteLine($"{Name} use Sword Attack deals {Power} damage");
        }

        public override void Skill(Player PPL)
        {
            PPL.Hp -= Power * 2;
            Console.WriteLine($"{Name} use Strong Strong Attack deals {Power} damage");
        }
    }
}