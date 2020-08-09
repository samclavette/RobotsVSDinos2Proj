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
        Random rand;

        public Robot(string name, int health, int powerLevel)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            attackPower = weapon.attackPower;
            weapon = ChooseWeapon();
        }

        public void RobotAttack(Dinosaur dino)
        {
            dino.health -= attackPower;
            powerLevel -= 10;            
        }

        public Weapon ChooseWeapon()
        {
            int index = rand.Next(weapon.weaponList.Count);
            return weapon.weaponList[index];
        }
    }
}
