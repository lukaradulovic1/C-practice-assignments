using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class Roomba : Robot
    {
        private readonly string name = "Willy";
        private readonly Engine engine = new();
        private readonly Vacuum vacuum = new();
        public void Drive()
        {
            engine.Drive();
        }

        public void Clean()
        {
            vacuum.Clean(name);
        }
    }
}
