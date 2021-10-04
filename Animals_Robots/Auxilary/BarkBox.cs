using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
   public class BarkBox
    {
        public virtual void Bark(string name)
        {
            Console.WriteLine($"{name} has barked.");
        }
    }
}
