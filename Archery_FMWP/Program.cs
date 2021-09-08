using System;
//Implement an Archer class. The archer has a Bow, multiple Arrows, an accuracy (number between 0.01 [worst] and 1 [best]),
//an arrow velocity (meters per second), and a distance from the target (meters [max 300]).

//The Bow has a loaded Arrow. Each Arrow has a hit probability (number between 0 [always misses]
//and 1 [always hits]), velocity (meters per second),
//the distance from target (meters), info whether the arrow has been released,
//and info whether the arrow has hit or missed the target.
namespace Archery_FMWP
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer archer = new();

            Arrow arrow = new();
            Console.WriteLine(arrow.HitProbability);
        }
    }
}
