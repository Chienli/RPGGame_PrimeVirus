using System;

namespace RPGGame_PrimeVirus
{
    public class Priest : Player
    {
        public Priest()
        {
            Hp = 150;
            MaxHp = 150;
            Job = "Priest";
            Power = 15;
        }

        public override void Attack(Player PPL)
        {
            base.Attack(PPL);
            Console.WriteLine($"{Name} use Holy Attack deals {Power} damage");
        }

        public override void Skill(Player PPL)
        {
            Hp += Power * 2;
            Hp = Hp > MaxHp ? MaxHp : Hp;
            Console.WriteLine($"{Name} Heals {Power * 2} Hp");
        }
    }
}