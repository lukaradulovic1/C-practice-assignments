using Animals_Robots.Auxilary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class MurderRobot : Robot
    {
        private readonly string name = "Murder bot 3000";
        private readonly Engine engine = new();
        private readonly Laser laser = new();
        public void Drive()
        {
            engine.Drive();
        }
        public void Kill()
        {
            laser.Kill();
        }
    }
}
