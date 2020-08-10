using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Fleet fleet1 = new Fleet();
        public Herd herd1 = new Herd();

        public Battlefield()
        {

        }

        public void PopulateBattlefield()
        {
            fleet1.AddRobottoFleet(fleet1.CreateRobot("Smasher", 100, 100));
            fleet1.AddRobottoFleet(fleet1.CreateRobot("Metal Mouth", 100, 100));
            fleet1.AddRobottoFleet(fleet1.CreateRobot("Rusty Bicep", 100, 100));

            herd1.AddDinosaurToHerd(herd1.CreateDinosaur("T-Rex", 100, 100, 20));
            herd1.AddDinosaurToHerd(herd1.CreateDinosaur("Stegga", 100, 100, 20));
            herd1.AddDinosaurToHerd(herd1.CreateDinosaur("Raptor", 100, 100, 20));

        }


    }
}
