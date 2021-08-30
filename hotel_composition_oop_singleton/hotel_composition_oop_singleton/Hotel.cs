using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// add a room, remove a room, clear all rooms, print the hotel spec to console, print the hotel spec to a file
public class Hotel
{
    private readonly List<HotelFloor> hotelFloors;
    private static readonly Hotel _instance = new Hotel();


    public Hotel()
    {
        hotelFloors = new();

    }

    public static Hotel GetHotel()
    {
        return _instance;
    }

    public void AddRoom(int floorNumber, HotelRoom room)
    {
        HotelFloor floor = null;

        foreach (var currentFloor in hotelFloors)
        {
            if (currentFloor.FloorNumber == floorNumber)
            {
                floor = currentFloor;
                break;
            }
        }

        if (floor == null)
        {
            floor = new HotelFloor(floorNumber);
        }


        floor.AddRoom(room);
        hotelFloors.Add(floor);

    }


    public void RemoveRoom(int floorNumber, int roomNumber)
    {
        foreach (var currentFloor in this.hotelFloors.ToList())
        {
            if (currentFloor.FloorNumber == floorNumber)
            {
                currentFloor.RemoveRoom(roomNumber);

            }
        }
        Console.WriteLine($"Room number {roomNumber} on the floor {floorNumber} has been removed.");
        Console.WriteLine();
    }

    public void PrintHotelSpec()
    {
        for (int i = 0; i < hotelFloors.Count; i++)
        {
            Console.WriteLine(hotelFloors[i].ToString());
        }
        Console.WriteLine();
    }

    public void PrintHotelFile(string path)
    {

        using var sw = new StreamWriter(path);

        foreach (var floor in hotelFloors)
        {
            sw.WriteLine("\n" + floor.ToString());
            Console.WriteLine("File has been written");
        }
    }

    public void ClearAllData()
    {
        if (hotelFloors.Count <= 0)
        {
            Console.WriteLine("\nThere is not data here.\n");
        }
        else
        {
            hotelFloors.Clear();
            Console.WriteLine("The hotel data list is now empty.");
            Console.WriteLine("Press 5 again to confirm.\n");
        }
    }
}

