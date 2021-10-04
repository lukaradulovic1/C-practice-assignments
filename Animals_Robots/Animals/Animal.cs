using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class Animal
    {
        private Butt butt = new Butt();
        private readonly string name;
        public virtual void Poop()
        {
            butt.Poop();
        }

    }
}

