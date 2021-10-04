using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class Dog : Animal
    {
        private readonly Butt butt = new();
        private readonly BarkBox barkBox = new();
        private readonly string name = "Rex";
        public override void Poop()
        {
            butt.Poop();
        }

        public void Bark()
        {
            barkBox.Bark(name);
        }
    }
}
