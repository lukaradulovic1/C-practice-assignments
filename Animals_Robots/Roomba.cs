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
        public override void Drive()
        {
            Console.WriteLine($"{name} is driving around");
        }
        public void Clean()
        {
            Console.WriteLine($"{name} is cleaning.");
        }
    }
}
