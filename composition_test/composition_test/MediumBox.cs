using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition_test
{
   public class MediumBox
    {
        private SmallBox smallBox;
        public void PrintSize()
        {
            Console.WriteLine("I'm a medium box, aka medio caja.");

            if (smallBox != null) 
            {
                Console.WriteLine($"I contain small box who says:");
                smallBox.PrintSize();
            }
            else
            {
                Console.WriteLine("I'm empty.");
            }

        }
        public void AddBox()
        {
            smallBox = new SmallBox();
        }
    }
}
