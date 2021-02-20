using System;
namespace pa2_EJsimoneaux_1
{
    public class Character
    {
        public string Name {get;set;}
        public int MaxPower{get;set;}
        public double Health{get;set;}
        public double AttackPower{get;set;}
        public double DefensePower{get;set;}
        public IAttack attackBehavior;
        public IDefend defenseBehavior;
        public string Type {get;set;}
        


        public void SetAttackBehavior (IAttack value)
        {
            attackBehavior = value;
        }
        public Character()
        {
            var rand = new Random();
            MaxPower = rand.Next(1,101);
            Health = 100;
            AttackPower = rand.Next(1, MaxPower+1);
            DefensePower = rand.Next(1, MaxPower+1);
           

        }
        public void SetDefenseBehavior (IDefend value)
        {
            defenseBehavior = value;
        }
        public void Defend (double power)
        {
            power = defenseBehavior.Defend(power);
            Health -= power;
            Console.WriteLine($"{power} damage done to {this.Name}!");
        }
        public void Stats()
        {
            Console.WriteLine($"\nName: {Name}\nHealth: {Health}\nAttack Power: {AttackPower}\nDefense Power: {DefensePower}\n");
            
        }
        // Character wind = new WindCharacter(){Name = "Wind", Health = 100, MaxPower = 75, AttackPower = 50, DefensePower = 75};
        // Character fire = new FireCharacter(){Name = "Fire", Health = 100, MaxPower = 75, AttackPower = 50, DefensePower = 75};
        // Character earth = new EarthCharacter(){Name = "Earth", Health = 100, MaxPower = 75, AttackPower = 50, DefensePower = 75};
        



    }
}