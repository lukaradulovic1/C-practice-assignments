using System;


public class Arrow
{
    private double hitProbability;
    private double velocity;
    private double distanceFromTarget;
    private const double MAX_DISTANCE = 300;


    public double DistanceFromTarget
    {
        get
        {
            return this.distanceFromTarget;
        }
    }

    public bool ReachedTarget
    {
        get
        {
            if (distanceFromTarget <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public bool HitTarget
    {
        get;
        private set;
    }

    public double HitProbability
    {
        get
        {
            return this.hitProbability;
        }

    }
    // Release method which sets all the arrow parameters and releases the arrow, 
    public void Release(double distanceFromTarget, double accuracy, double velocity)
    {
        this.velocity = velocity;
        this.distanceFromTarget = distanceFromTarget;

        // bool 
        this.HitTarget = false;

        this.hitProbability = Math.Pow(Math.E, -Math.Pow((2 * distanceFromTarget / MAX_DISTANCE / accuracy), 2));

    }
    public void Update(double deltaTime)
    {
        var deltaDistance = velocity * deltaTime;
        var newDistanceFromTarget = distanceFromTarget - deltaDistance;
        distanceFromTarget = newDistanceFromTarget;


        if(ReachedTarget == true)
        {
            var rnd = new Random();
            
            var randomDouble = rnd.NextDouble();

            if(randomDouble < hitProbability)
            {
                HitTarget = true;
            }
            else 
            { 
                HitTarget = false;
            }
        }
    }
}




