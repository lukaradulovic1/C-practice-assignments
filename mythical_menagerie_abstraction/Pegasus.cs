using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Hydra, Medusa, Cerberus, Cyclops, Manticore
namespace mythical_menagerie_abstraction
{
    public class Pegasus : MythicalCreature
    {
        public override string Name
        {
            get
            {
                return "Pegasus";
            }
        }

        public override string AffiliatedDiety
        {
            get
            {
                return "Zeus probably";
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
                return "gud";
            }
        }

        public override string SpecialAbility
        {
            get
            {
                return "Huge horse that can fly";
            }
        }
        public override string ToString()
        {
            string info = Name + " " + AffiliatedDiety + " " + Area + " " + Alignment + " " + SpecialAbility;

            return info;

        }
    }
}
