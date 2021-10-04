using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
   public  class Cat : Animal
    {
        private readonly string name = "Kitty";
        public override void Poop()
        {
            Console.WriteLine($"{name} has pooped.");
        }
        public  void Meow()
        {
            Console.WriteLine($"{name} has meowed.");
        }
    }
}
