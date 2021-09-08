using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Arrow
{
    private double hitProbability;
    private double velocity;
    private double distanceFromTarget;
    private bool arrowReleased;
    private bool arrowHit;
    const double MAXDISTANCE = 300;
    private double accuracy;


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
            return ReachedTarget;
        }

    }

    public bool HitTarget
    {
        get
        {
            return HitTarget;
        }

    }

    public double HitProbability
    {
        get
        {
            return this.hitProbability;
        }

    }
    //Release method which sets all the arrow parameters and releases the arrow, 
    public void Release(double distanceFromTarget)
    {
        this.velocity = 150;
        this.distanceFromTarget = distanceFromTarget;

        //randomizing accuracy 
        Random randomAccuracyValue = new Random();
        this.accuracy = randomAccuracyValue.NextDouble();

        //bool 
        this.arrowReleased = true;
        this.arrowHit = false;

        this.hitProbability = Math.Pow(Math.E, Math.Pow(-(2 * distanceFromTarget / MAXDISTANCE / accuracy), 2));

        if(hitProbability > 0)
        {
            this.arrowHit = true;
        }
        if(distanceFromTarget <= 0)
        {
            this.distanceFromTarget = 0;
        }
    }
    public void Update()
    {

    }
}




