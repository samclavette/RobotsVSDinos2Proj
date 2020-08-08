using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    public class Fleet
    {
        Robot robotOne;
        Robot robotTwo;
        Robot robotThree;
        public List<Robot> robotList;
        public Fleet()
        {
            Robot robotOne = new Robot("Sonny", 100, 50, 50);
            Robot robotTwo = new Robot("Ultron", 150, 75, 75);
            Robot robotThree = new Robot("Wall-E", 75, 40, 40);
            robotList = new List<Robot>();
        }

        public void AddRobotsToList()
        {
            robotList.Add(robotOne);
            robotList.Add(robotTwo);
            robotList.Add(robotThree);
        }
    }
}
