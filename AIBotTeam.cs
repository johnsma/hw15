using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class AIbotTeam : AIbot
    {
        public string _Purpose { get; set; }

        public AIbotTeam(string name, int strength, string purpose): base(name, strength)
        {
            _Name = name;
            _Strength = strength;
            _Purpose = purpose;
        }
        public void End()
        {
            Console.WriteLine("This is how the story ends!");
        }
    }
}