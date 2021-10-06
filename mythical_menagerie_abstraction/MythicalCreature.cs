using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mythical_menagerie_abstraction
{//Each mythical creature should have a name, affiliated deity, area, alignment, and special ability
    public abstract class MythicalCreature
    {
        private readonly string name;
        private readonly string affiliatedDiety;
        private readonly string area;
        private readonly string alignment;
        private readonly string specialAbility;

        public string Name
        {
            get 
            { 
                return this.name; 
            }
        }
        public string AffiliatedDiety
        {
            get
            {
                return this.affiliatedDiety;
            }
        }
        public string Area
        {
            get 
            { 
                return this.area; 
            }
        }

        public string Alignment
        {
            get 
            { 
                return this.alignment; 
            }
        }
        public string SpecialAbility 
        { 
            get 
            { 
                return this.specialAbility;
            } 
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
