using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizard_nursery_factory
{
    class WizardBaby
    {
        private readonly string name;
        private readonly string title;

        public WizardBaby(string name, string title)
        {
            this.name = name;
            this.title = title;
        }


        public override string ToString()
        {
            return name + " " + title;
        }
    }
}