using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class MurderRobotDog : Robot
    {
        private readonly string name = "test name";
        private Dog testDog = new();
        private MurderRobot testMurderRobot = new();

        public void Bark()
        {
            
            testDog.Bark();
        }

        public void Poop()
        {
            testDog.Poop();
        }
        public  void Kill()
        {
            testMurderRobot.Kill();
        }

    }
}
