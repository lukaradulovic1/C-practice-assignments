using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class Animal
    {
        public virtual void Poop()
        {
            Console.WriteLine("The animal has pooped.");
        }
    }
}
