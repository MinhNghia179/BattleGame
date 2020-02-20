using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Zeus = new Warrior("Zeus", 1000, 120, 40);
            Warrior Hade = new Warrior("Hade", 1000, 120, 20);
            Battle.StarFight(Zeus, Hade);
            Console.ReadLine();
        }
    }
}
