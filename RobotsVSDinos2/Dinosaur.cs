using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    class Dinosaur
    {
        public string type;
        public int health;
        public int energyLevel;
        public int attackPower;

        public Dinosaur(string type, int health, int energyLevel, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energyLevel = energyLevel;
            this.attackPower = attackPower;
        }
    }
}
