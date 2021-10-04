using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Robots
{
    public class Vacuum
    {
        public virtual void Clean(string name)
        {
            Console.WriteLine($"{name} is cleaning.");
        }
    }
}
