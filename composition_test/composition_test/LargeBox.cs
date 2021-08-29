using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composition_test
{
   public class LargeBox
    {
        private MediumBox mediumBox;
        public void PrintSize()
        {
            Console.WriteLine("I'm a large box, aka grande caja.");

            if (mediumBox != null)
            {
                Console.WriteLine($"I contain medium box who says:");
                mediumBox.PrintSize();
            }
            else
            {
                Console.WriteLine("I'm empty.");
            }

        }
        public void AddBoxes()
        {
            mediumBox = new MediumBox();
            mediumBox.AddBox();
        }
    }
}
