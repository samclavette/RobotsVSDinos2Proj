using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    class Battlefield
    {
        public Herd dinoHerd;
        public Fleet robotFleet;

        public Battlefield()
        {
            dinoHerd = new Herd();
            robotFleet = new Fleet();
        }

        public void RobotAttackDino()
        {
            Robot attackingRobot = robotFleet.ChooseRandomRobot();
            Dinosaur defendingDino = dinoHerd.ChooseRandomDino();
            attackingRobot.RobotAttack(defendingDino);
        }

        public void DinoAttackRobot()
        {
            Dinosaur attackingDino = dinoHerd.ChooseRandomDino();
            Robot defendingRobot = robotFleet.ChooseRandomRobot();
            attackingDino.DinoAttack(defendingRobot);
        }
    }
}
