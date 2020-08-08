using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    class Fleet
    {
        public Fleet()
        {
            Robot robotOne = new Robot("Sonny", 100, 50, 50);
            Robot robotTwo = new Robot("Ultron", 150, 75, 75);
            Robot robotTHree = new Robot("Wall-E", 75, 40, 40);
        }
    }
}
