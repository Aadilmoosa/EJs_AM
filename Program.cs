using System.Net.Mime;
using System.Runtime.CompilerServices;
using System;

namespace pa2_EJsimoneaux_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character me = new Character();
            Character opponent = new Character();
            

            int choice = 0;
            int choice2 = 0;
            string name;

            

            while (choice != 5)
            {
                Console.WriteLine("Choose your fighter: \n1. Fire\n2. Wind\n3. Earth\n4. Exit");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("What do you want your character's name to be? (press ENTER if exiting):");
                name = Console.ReadLine();
                if(choice == 1)
                {
                    me = new FireCharacter(){Name = name};
                   // me.type = Fire
                    
                }
                else if(choice == 2)
                {
                    me = new WindCharacter(){Name = name};
                   // me.type = Wind
                }
                else if (choice == 3)
                {
                    me = new EarthCharacter(){Name = name};
                    //me.type=Earth
                }
                else
                {
                    System.Environment.Exit(1);
                }
                
                me.Stats();
                Console.WriteLine("Is this correct?  Press 5 if correct:");
                choice = int.Parse(Console.ReadLine());
            }
            while (choice2 != 5)
            {
                Console.WriteLine("Choose your opponent's fighter: \n1. Fire\n2. Wind\n3. Earth\n4. Exit");
                choice2 = int.Parse(Console.ReadLine());
                Console.WriteLine("What do you want your opponent's character's name to be? (Press ENTER if exiting):");
                name = Console.ReadLine();
                if(choice2 == 1)
                {
                    opponent = new FireCharacter(){Name = name};
                    //me.type = Fire
                    
                }
                else if(choice2 == 2)
                {
                    opponent = new WindCharacter(){Name = name};
                    
                }
                else if (choice2 == 3)
                {
                    opponent = new EarthCharacter(){Name = name};
                   
                }
                else
                {
                    System.Environment.Exit(1);
                }
                opponent.Stats();
                Console.WriteLine("Is this correct?  Press 5 if correct:");
                choice2 = int.Parse(Console.ReadLine());
            }

            var rand = new Random();
            int num = rand.Next(0,2);

            while (me.Health > 0 && opponent.Health > 0)
            {
                
                if(num == 0)
                {
                    me.attackBehavior.Attack(me, opponent);
                    opponent.Stats();
                    opponent.attackBehavior.Attack(opponent, me);
                    me.Stats();
                } 
                else
                {
                    //opponent.attackBehavior.Attack(opponent, me);
                    me.Stats();
                    me.attackBehavior.Attack(me, opponent);
                    opponent.Stats();
                }
                
            }
            if(me.Health > 0)
            {
                Console.WriteLine($"{me.Name} won!");
            }
            else
            {
                Console.WriteLine($"{opponent.Name} won!");
            }

            





            
            

            
            
        }
    }
}