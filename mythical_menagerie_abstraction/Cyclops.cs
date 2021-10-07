using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mythical_menagerie_abstraction
{
    public class Cyclops : MythicalCreature
    {
        public override string Name
        {
            get
            {
                return "Cyclops";
            }
        }

        public override string AffiliatedDiety
        {
            get
            {
                return "NO clue";
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
                return "something";
            }
        }

        public override string SpecialAbility
        {
            get
            {
                return "huge head, one eye";
            }
        }
        public override string ToString()
        {
            string info = Name + " " + AffiliatedDiety + " " + Area + " " + Alignment + " " + SpecialAbility;

            return info;

        }
    }
}
