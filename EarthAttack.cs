using System;
namespace pa2_EJsimoneaux_1
{
    public class EarthAttack : IAttack
    {
        public void Attack(Character me, Character opponent)
        {
            Console.WriteLine(me.Name + " hit you with Earth attack!");
            double attackPower;
            if(opponent.Type== "Fire")
            {
                attackPower = me.AttackPower * 1.2;

            }
            else
            {
                attackPower = me.AttackPower;
            }

    
            opponent.Defend(attackPower);
        }
    }
}