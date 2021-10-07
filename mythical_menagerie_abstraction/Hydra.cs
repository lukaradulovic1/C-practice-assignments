using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mythical_menagerie_abstraction
{
   public class Hydra : MythicalCreature
    {
        public override string Name
        {
            get
            {
                return "Hydra";
            }
        }

        public override string AffiliatedDiety
        {
            get
            {
                return "sneaky something";
            }
        }

        public override string Area
        {
            get
            {
                return "Greece";
            }
        }

        public override string Alignment
        {
            get
            {
                return "evil i guess";
            }
        }

        public override string SpecialAbility
        {
            get
            {
                return "Multiple snake heads on a dragon-ish body";
            }
        }
        public override string ToString()
        {
            string info = Name + " " + AffiliatedDiety + " " + Area + " " + Alignment + " " + SpecialAbility;

            return info;

        }
    }
}
