using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mythical_menagerie_abstraction
{//Each mythical creature should have a name, affiliated deity, area, alignment, and special ability
    public class MythicalCreature
    {
        private string name;
        private string affiliatedDiety;
        private string area;
        private string alignment;
        private string specialAbility;

        public MythicalCreature(string name, string affiliatedDiety, string area, string alignment, string specialAbility)
        {
            this.name = name;
            this.affiliatedDiety = affiliatedDiety;
            this.area = area;
            this.alignment = alignment;
            this.specialAbility = specialAbility;

        }



        public override string ToString()
        {
            string info = name + " " + affiliatedDiety + " " + area + " " + alignment + " " + specialAbility;
            return info;
        }
    }
}
