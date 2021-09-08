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

    public void Release()
    {
        this.hitProbability = Math.Pow(Math.E, Math.Pow(-(2 * distanceFromTarget / MAXDISTANCE / accuracy), 2));
    }
    public void Update()
    {

    }
}




