using System;
namespace pa2_EJsimoneaux_1
{
    public class FireAttack : IAttack
    {
        public void Attack(Character me, Character opponent)
        {
            Console.WriteLine(me.Name + " hit you with Fire attack!");
            double attackPower;
            if(opponent.Type== "Wind")
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