using System;
using System.Collections.Generic;

public class Customs
{
    private readonly List<Passenger> passengers;
    private readonly double inspectionQuality;
    private readonly List<Passenger> aprehendedPassengers;
    private int passedCheck;
    
    
    public int PassengersRemaining 
    { 
        get 
        { 
            return passengers.Count; 
        } 
    }

    public int PassedCheck
    {
        get => passedCheck;
    }

    public List<Passenger> AprehendedPassengers
    {
        get
        {
            return this.aprehendedPassengers;
        }
    }

    public Customs(List<Passenger> passengers, double inspectionQuality)
    {
        aprehendedPassengers = new List<Passenger>();
        this.passedCheck = 0;
        this.passengers = passengers;
        this.inspectionQuality = inspectionQuality;
    }


    public void ProccessNextPassenger()
    {
        var currentPassenger = passengers[0];
        var shadinesLevel = CheckShadinessLevel(currentPassenger);
        var thoroughness = Math.Sqrt(shadinesLevel * inspectionQuality);
        var searchResult = SearchPassenger(currentPassenger, thoroughness);
        if (searchResult.contrabandFound == true)
        {
            this.AprehendPassenger(currentPassenger);
        }
        else
        {
            this.LetPassengerThrough(currentPassenger);
        }
        passengers.Remove(currentPassenger);
    }
    private double CheckShadinessLevel(Passenger passenger)
    {
        return passenger.ShadinessFactor;
    }
    private SearchResult SearchPassenger(Passenger passenger, double thoroughness)
    {
        var luggage = passenger.HandOverLuggage();
        var searchResult = luggage.Search(thoroughness);
        if (searchResult.contrabandFound == false)
        {
            passenger.RetrieveLuggage(luggage);
        }
        return searchResult;
    }

    private void AprehendPassenger(Passenger passenger)
    {
        AprehendedPassengers.Add(passenger);
    }
    private void LetPassengerThrough(Passenger passenger)
    {
        passedCheck++;
    }
    public void RandomSecurityCheck()
    {
        var currentPassenger = passengers[0];
        var thoroughness = inspectionQuality;
        var searchResult = SearchPassenger(currentPassenger, thoroughness);
        if (searchResult.contrabandFound == true)
        {
            this.AprehendPassenger(currentPassenger);
        }
        else
        {
            this.LetPassengerThrough(currentPassenger);
        }
        passengers.Remove(currentPassenger);
    }

}

