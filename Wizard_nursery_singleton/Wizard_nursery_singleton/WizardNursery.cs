using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wizard_nursery_factory
{
    class WizardNursery
    {
        private readonly string title;

        public WizardNursery(string title)
        {
            this.title = title;
        }

        public WizardBaby CreateBaby(string name)
        {
            var wizardBaby = new WizardBaby(name, title);
            return wizardBaby;
        }


    }
}