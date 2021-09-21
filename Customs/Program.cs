using System;
using System.Collections.Generic;

public class Program
{
    private static readonly double randomCheckProbability = 0.1;

    static void Main()
    {
        List<Passenger> listOfPassengers = new List<Passenger>();

        for (int i = 0; i < 50; i++)
        {
            var newPassenger = new Passenger();
            listOfPassengers.Add(newPassenger);
        }
        var rnd = new Random();
        var inspectionQuality = rnd.NextDouble();
        Customs customs = new(listOfPassengers, inspectionQuality);

        while (customs.PassengersRemaining > 0)
        {
            if (rnd.NextDouble() < randomCheckProbability)
            {
                customs.RandomSecurityCheck();
            }
            else
            {
                customs.ProccessNextPassenger();
            }
        }

        Console.WriteLine($"Customs have aprehended {customs.AprehendedPassengers.Count} passengers.");
        Console.WriteLine($"Customs have checked and cleared {customs.PassedCheck} passengers.");

    }
}

