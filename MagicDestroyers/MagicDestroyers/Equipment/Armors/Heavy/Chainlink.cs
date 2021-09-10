using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors
{
   public class Chainlink
    {
        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }

            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"The selected damage value of {armorPoints} for the sword is too low. Needs to be greater than 0");

                }
            }
        }
    }
}
