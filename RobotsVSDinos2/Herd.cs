using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVSDinos2
{
    class Herd
    {
        public Dinosaur dinoOne;
        public Dinosaur dinoTwo;
        public Dinosaur dinoThree;
        public List<Dinosaur> dinoList;
        Random rand;

        public Herd()
        {
            Dinosaur dinoOne = new Dinosaur("Raptor", 75, 40, 40);
            Dinosaur dinoTwo = new Dinosaur("T-Rex", 150, 75, 75);
            Dinosaur dinoThree = new Dinosaur("Stegosaurus", 100, 50, 50);
            dinoList = new List<Dinosaur>();
        }

        public void AddDinosToList()
        {
            dinoList.Add(dinoOne);
            dinoList.Add(dinoTwo);
            dinoList.Add(dinoThree);
        }

        public Dinosaur ChooseRandomDino()
        {
            int index = rand.Next(dinoList.Count);
            Dinosaur dinoChosen = dinoList[index];
            return dinoChosen;
        }

    }
}
