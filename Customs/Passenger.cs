using System;
using System.Collections.Generic;

public class Passenger
{
    private Luggage luggage;
    private readonly double shadinessFactor;

    public double ShadinessFactor
    {
        get
        {
            return shadinessFactor;
        }
    }

    public Passenger()
    {
        var rnd = new Random();
        this.shadinessFactor = Math.Pow(rnd.NextDouble(), 5);
        List<LuggageItem> luggageItems = CreateLuggageItems();
        this.luggage = new(luggageItems);
    }

    private List<LuggageItem> CreateLuggageItems()
    {
        var contrabandCount = ChooseContrabandCount();
        List<LuggageItem> luggageItems = new();
        for (int i = 0; i < Luggage.CAPACITY; i++)
        {
            if (i < contrabandCount)
            {
                var contraband = new ContrabandItem();
                luggageItems.Add(contraband);
            }
            else
            {
                var legalItem = new LegalItem();
                luggageItems.Add(legalItem);
            }
        }

        return luggageItems;
    }

    private int ChooseContrabandCount()
    {
        var contrabandCountDouble = Math.Pow(this.shadinessFactor, 2) * Math.Log(Luggage.CAPACITY);
        var contrabandCount = Convert.ToInt32(contrabandCountDouble);
        return contrabandCount;
    }

    public Luggage HandOverLuggage()
    {
        var luggage = this.luggage;
        this.luggage = null;
        return luggage;
    }

    public void RetrieveLuggage(Luggage luggage)
    {
        this.luggage = luggage;
    }

}

