using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mythical_menagerie_abstraction
{//Each mythical creature should have a name, affiliated deity, area, alignment, and special ability
    public abstract class MythicalCreature
    {

        public abstract string Name
        {
            get;
        }
        public abstract string AffiliatedDiety
        {
            get;
        }
        public abstract string Area
        {
            get;
        }

        public abstract string Alignment
        {
            get;
        }
        public abstract string SpecialAbility 
        {
            get;
        }

        //public MythicalCreature(string name, string affiliatedDiety, string area, string alignment, string specialAbility)
        //{
        //    this.name = name;
        //    this.affiliatedDiety = affiliatedDiety;
        //    this.area = area;
        //    this.alignment = alignment;
        //    this.specialAbility = specialAbility;

        //}



        public override string ToString()
        {
            string info = Name + " " + AffiliatedDiety + " " + Area + " " + Alignment + " " + SpecialAbility;
            return info;
        }
    }
}
