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
    }
}
