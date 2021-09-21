using System;
using System.Collections.Generic;
public class Luggage
{
    private readonly List<LuggageItem> luggageItems;
    public const int CAPACITY = 10;

    public Luggage(List<LuggageItem> luggageItems)
    {
        if (luggageItems.Count > CAPACITY || luggageItems.Count < 0)
        {
            throw new Exception();
        }
        this.luggageItems = luggageItems;
    }



    public SearchResult Search(double thoroughness)
    {
        Random rnd = new Random();
        var searchResult = new SearchResult();
        foreach (var item in this.luggageItems)
        {
            var missAnItem = rnd.NextDouble() > thoroughness;

            if (missAnItem == true)
            {
                continue;
            }
            if (item is ContrabandItem)
            {
                searchResult.contrabandItems.Add((ContrabandItem)item);
                searchResult.contrabandFound = true;
            }
        }
        return searchResult;
    }



}

