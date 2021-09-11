using System;

namespace Archery_FMWP
{
    /*The Main program should first allow configuration of the Archer 
     * (input the number of arrows, 
     * accuracy, arrow velocity, and distance from target), */
    class Program
    {
        private const double DELTA_TIME = 0.1;
        static void Main()
        {
            
            Console.WriteLine("Type in the number of arrows: ");
            var numberOfArrows = int.Parse(Console.ReadLine());

            Console.WriteLine("Type in the value for the accuracy: ");
            var accuracyValue= double.Parse(Console.ReadLine());

            Console.WriteLine("Type in the value for arrow velocity: ");
            var arrowVelocity = double.Parse(Console.ReadLine());

            Console.WriteLine("Type in the distance from target: ");
            var distanceFromTarget = double.Parse(Console.ReadLine());

            var arrowHit = 0;
            var arrowMiss = 0;

            Archer archer = new(numberOfArrows, accuracyValue, arrowVelocity, distanceFromTarget);
            
            for (int i = 0; i < numberOfArrows; i++)
            {
                archer.LoadBow();

                var arrow = archer.ShootBow();

                while (arrow.ReachedTarget == false)
                {
                    Console.ReadLine();
                    arrow.Update(DELTA_TIME);
                    Console.WriteLine(arrow.DistanceFromTarget);
                }
                if (arrow.HitTarget)
                    {
                    arrowHit++;
                        Console.WriteLine($"{arrow} has hit the target");
                    }
                    else {Console.WriteLine($"{arrow} hasnt hit the target");
                        
                }
            }
        }
    }
}
