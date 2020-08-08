using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    public class Robot
    {
        public string name;
        public int health;
        public int powerLevel;
        Weapon weapon;
        public int attackPower;

        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            attackPower = weapon.attackPower;
        }
        
    }
}
