using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mythical_menagerie_abstraction
{
    public class Medusa : MythicalCreature
    {
        public override string Name
        {
            get
            {
                return "Medusa";
            }
        }

        public override string AffiliatedDiety
        {
            get
            {
                return "Snake head affiliation inc.";
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
                return "something snakey";
            }
        }

        public override string SpecialAbility
        {
            get
            {
                return "Turns to stone anyone she locks eyes with";
            }
        }
        public override string ToString()
        {
            string info = Name + " " + AffiliatedDiety + " " + Area + " " + Alignment + " " + SpecialAbility;

            return info;

        }
    }
}
