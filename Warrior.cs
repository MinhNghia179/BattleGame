using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject2
{
    class Warrior
    {
        public string Name { get; set; } = " Warrior";

        public double Heathy { get; set; } = 0;
        public double AttkMax { get; set; } = 0;

        public double BlockMax { get; set; } = 0;

        Random rnd = new Random();

        public Warrior(string name = "Warrior",
            double heathy = 0,
            double attkMax = 0,
            double blockMax = 0) {

            Name = name;
            Heathy = heathy;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }

        public double Attack()
        {
            return rnd.Next(1, (int)AttkMax);
        }

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }
    }
}
