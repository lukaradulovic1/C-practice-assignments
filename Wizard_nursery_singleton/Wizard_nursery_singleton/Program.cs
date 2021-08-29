using System;
using System.Collections.Generic;

namespace wizard_nursery_factory
{
    class Program
    {
        static void Main()
        {


            Console.WriteLine("Please type in the nursery name: ");
            var title = Console.ReadLine();
            var nursery = new WizardNursery(title);

            List<WizardBaby> wizardBabies = new();

            while (true)
            {
                Console.WriteLine("Existing baby/babies are: ");
                for (int i = 0; i < wizardBabies.Count; i++)
                {
                    Console.WriteLine(wizardBabies[i]);
                }


                Console.WriteLine("Type in baby name: ");
                var babyName = Console.ReadLine();

                if (babyName.Length == 0)
                {
                    break;
                }

                WizardBaby baby = nursery.CreateBaby(babyName);
                wizardBabies.Add(baby);



            }
        }
    }
}