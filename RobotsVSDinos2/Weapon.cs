using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    public class Weapon
    {
        public string type;
        public int attackPower;
        public List<Weapon> weaponList;

        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
            Weapon weaponOne = new Weapon("sword", 75);
            Weapon weaponTwo = new Weapon("hammer", 50);
            Weapon weaponThree = new Weapon("gatling gun", 100);
            Weapon weaponFour = new Weapon("machete", 50);
            weaponList = new List<Weapon>();
        }
    }
}
