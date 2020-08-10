using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public string weaponType;
        public int weaponPower;

        public Weapon(string type, int power)
        {
            this.weaponType = type;
            this.weaponPower = power;
        }
    }
}
