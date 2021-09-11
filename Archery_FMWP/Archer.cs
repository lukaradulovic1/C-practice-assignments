using System;
using System.Collections.Generic;

public class Archer
{
    private List<Arrow> arrows;
    private Bow bow;
    private double accuracy;
    private double arrowVelocity;
    private double distanceFromTarget;

    public Archer(int arrowNumber, double accuracy, double arrowVelocity, double distanceFromTarget)
    {
        this.arrows = new List<Arrow>(arrowNumber);
        for (int i = 0; i < arrowNumber; i++)
        {
            Arrow arrow = new();
            arrows.Add(arrow);
        }

        this.bow = new();
        this.accuracy = accuracy;
        this.arrowVelocity = arrowVelocity;
        this.distanceFromTarget = distanceFromTarget;
    }


    //property
    public int ArrowCount
    {
        get
        {
            return arrows.Count;
        }

    }

    //methods
    public void LoadBow()
    {
        var currentArrow = arrows[0];
        arrows.Remove(currentArrow);
        bow.Load(currentArrow);
    }

    public Arrow ShootBow()
    {
        var arrow = bow.Shoot();
        arrow.Release(distanceFromTarget, accuracy, arrowVelocity);
        return arrow;
    }

}

