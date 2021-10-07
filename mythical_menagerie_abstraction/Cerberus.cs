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
                return "Cerberus";
            }
        }

        public override string AffiliatedDiety
        {
            get
            {
                return "Hades";
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
                return "Huge 3-headed dog";
            }
        }
        public override string ToString()
        {
            string info = Name + " " + AffiliatedDiety + " " + Area + " " + Alignment + " " + SpecialAbility;
             
            return info;
            
        }
    }
}
