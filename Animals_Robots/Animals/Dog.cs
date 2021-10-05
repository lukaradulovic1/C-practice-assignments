using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class Dog 
    {
        private readonly Butt butt = new();
        private readonly BarkBox barkBox = new();
        private readonly string name = "Rex";
        public void Poop()
        {
            butt.Poop();
        }

        public void Bark()
        {
            barkBox.Bark(name);
        }
    }
}
