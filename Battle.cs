using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject2
{
    class Battle
    {
        public static void StarFight(Warrior warrior1 , Warrior warrior2)
        {
            while(true)
            {
                if(GetAttackresult(warrior1,warrior2)=="Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if(GetAttackresult(warrior2,warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        public static string GetAttackresult(Warrior warriorA , Warrior warriorB)
        {
            double warA = warriorA.Attack();
            double warB = warriorB.Block();
            double Damage = warA - warB;
            if (Damage > 0)
            {
                warriorB.Heathy = warriorB.Heathy - Damage;
            }
            else Damage = 0;

            Console.WriteLine("{0} attack {1} anh deals {2} damage", warriorA.Name, warriorB.Name, Damage);

            Console.WriteLine("{0} has {1} heathy \n",warriorB.Name,warriorB.Heathy);

            if (warriorB.Heathy <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victory", warriorB.Name, warriorA.Name);
                return "Game Over";
            }
            else return " Fight Again";
        }
    }
}
