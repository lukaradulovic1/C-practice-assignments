using MagicDestroyers.Characters.Melee;
using System;

namespace MagicDestroyers
{
    class Program
    {
        static void Main(string[] args)
        {

            Assasin assassin = new Assasin("locoloco", 10, 200);
            Console.WriteLine(assassin.Name + " " + assassin.Level + " " + assassin.HealthPoints);
        }
    }
}
