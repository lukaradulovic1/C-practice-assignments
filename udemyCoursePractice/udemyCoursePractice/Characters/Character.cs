using Interfaces;
using System;

using System.Threading;



public abstract class Character 

{
    // fields
    private string name;
    protected int healthPoints;
    protected int weight;
    protected int age;

    // interface
     


    // properties
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
    // constructors

    public Character() 
    {
        
    }

    public Character(int healhtPoints, int weight, int age)
    {
        this.HealhtPoints = healhtPoints;
        this.Weight = weight;
        this.Age = age;
    }
    public void Greetings(string name)
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

    public virtual int Addition(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}

