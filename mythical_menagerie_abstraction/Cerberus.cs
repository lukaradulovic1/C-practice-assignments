using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mythical_menagerie_abstraction
{
    public class Cerberus : MythicalCreature
    {
        public override string Name
        {
            get
            {
                return Name;
            }
        }

        public override string AffiliatedDiety
        {
            get
            {
                return AffiliatedDiety;
            }
        }

        public override string Area
        {
            get
            {
                return Area;
            }
        }

        public override string Alignment
        {
            get
            {
                return Alignment;
            }
        }

        public override string SpecialAbility
        {
            get
            {
                return SpecialAbility;
            }
        }
    }
}
