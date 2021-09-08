using System;
using System.Collections.Generic;

public class Archer
{
    private List<Arrow> arrows;
    private Bow bow;
    private double accuracy;
    private float arrowVelocity;
    private float distanceFromTarget;


    //property
    public int ArrowCount 
    {
        get 
        { 
            return arrows.Count;
        }
         
    }

    //randomizing accuracy 
    Random randomAccuracyValue = new Random();
    
    //methods
    public void LoadBow()
    {

    }
    
    public void ShootBow()
    {
        
    }

}

