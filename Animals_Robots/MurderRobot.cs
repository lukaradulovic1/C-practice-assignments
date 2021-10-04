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
        public override void Drive()
        {
            Console.WriteLine($"{name} is driving around.");
        }
        public void Kill()
        {
            Console.WriteLine($"{name} has killed someone");
        }
    }
}
