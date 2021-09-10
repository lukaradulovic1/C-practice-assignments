using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


public class Character
{
    //fields
    private string name;
    protected int healthPoints;
    protected int weight;
    protected int age;



    //properties
    public int HealhtPoints
    {
        get
        {
            return this.healthPoints;
        }
        set
        {
            this.healthPoints = value;
        }
    }
    public int Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            this.weight = value;
        }
    }
    public virtual int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            if (value >= 18 && value <= 45)
            {


                this.age = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException(string.Empty, "Please use age between 18 and 45.");
            }
        }
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    //constructors

    public Character() 
    {
        
    }

    public Character(int healhtPoints, int weight, int age)
    {
        this.HealhtPoints = healhtPoints;
        this.Weight = weight;
        this.Age = age;
    }
    protected void Greetings(string name)
    {
        Console.WriteLine($@"{this.name} greets {name}");
    }

     public virtual void Move(int pauseBetweenMovements)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("I am moving.");
            Thread.Sleep(1000);
        }
    }
}

