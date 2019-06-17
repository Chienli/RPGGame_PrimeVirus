using System;

namespace RPGGame_PrimeVirus
{
    public class Novice : Player
    {
        public Novice()
        {
            Hp = 100;
            MaxHp = 100;
            Job = "Novice";
            Power = 20;
        }

        public override void Attack(Player PPL)
        {
            base.Attack(PPL);
            Console.WriteLine($"Stupid Attack deals {Power} damage");
        }

        public override void Skill(Player ppl)
        {
            Console.WriteLine("Please Dont Hurt Me");
        }
    }
}