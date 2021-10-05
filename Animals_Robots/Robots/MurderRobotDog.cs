using Animals_Robots.Auxilary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class MurderRobotDog 
    {
        private readonly string name = "Barkotron Prime 6000";
        private readonly Laser laser = new();
        private readonly BarkBox barkBox = new();
        private readonly Butt butt = new();
        public void Bark()
        {

            barkBox.Bark(name);
        }

        public void Poop()
        {
            butt.Poop();
        }
        public void Kill()
        {
            laser.Kill();
        }

    }
}
