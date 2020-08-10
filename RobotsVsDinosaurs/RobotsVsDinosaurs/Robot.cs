using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public Weapon weapon = new Weapon();

        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.robotName = name;
            this.robotHealth = health;
            this.robotPowerLevel = powerLevel;
            this.weapon = weapon;
        }
    }
}
