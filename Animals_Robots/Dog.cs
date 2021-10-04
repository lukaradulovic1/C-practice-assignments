using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class Dog : Animal
    {
        private readonly string name = "Rex";
        public override void Poop()
        {
            Console.WriteLine($"{name} has pooped.");
        }
        public void Bark()
        {
            Console.WriteLine($"{name} has barked.");
        }
    }
}
