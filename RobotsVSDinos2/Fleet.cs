using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    public class Fleet
    {
        public Robot robotOne;
        public Robot robotTwo;
        public Robot robotThree;
        public List<Robot> robotList;
        Random rand;
        public Fleet()
        {
            Robot robotOne = new Robot("Sonny", 100, 50);
            Robot robotTwo = new Robot("Ultron", 150, 75);
            Robot robotThree = new Robot("Wall-E", 75, 40);
            robotList = new List<Robot>();
            AddRobotsToList();
        }

        public void AddRobotsToList()
        {
            robotList.Add(robotOne);
            robotList.Add(robotTwo);
            robotList.Add(robotThree);
        }

        public Robot ChooseRandomRobot()
        {
            int index = rand.Next(robotList.Count);
            Robot robotChosen = robotList[index];
            return robotChosen;
        }
    }
}
