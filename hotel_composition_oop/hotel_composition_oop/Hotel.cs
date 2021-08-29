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



    public Hotel()
    {
        hotelFloors = new();

    }


    public void AddRoom(int floorNumber, HotelRoom room)
    {
        HotelFloor floor = null;

        foreach (var currentFloor in this.hotelFloors)
        {
            if (currentFloor.FloorNumber == floorNumber)
            {
                floor = currentFloor;
                break;
            }
        }
        if (!hotelFloors.Contains(floor))
        {
            floor = new HotelFloor(floorNumber);
        }


        floor.AddRoomsToFloor(floorNumber, room);
        hotelFloors.Add(floor);

    }


    public void RemoveRoom(int floorNumber, int roomNumber)
    {
        foreach (var currentFloor in this.hotelFloors.ToList())
        {
            if (currentFloor.FloorNumber == floorNumber)
            {
                currentFloor.RemoveRoomFromFloor(floorNumber, roomNumber);

            }
        }
        Console.WriteLine($"Room number {roomNumber} on the floor {floorNumber} has been removed.");
        Console.WriteLine();
    }

    public void PrintHotelSpec()
    {
        for (int i = 0; i < hotelFloors.Count; i++)
        {
            hotelFloors[i].HotelRoomPrint();
        }
        Console.WriteLine();
    }

    public void PrintHotelFile(List<HotelRoom> hotelSpecList)
    {
        List<HotelRoom> hotelList = hotelSpecList;
        var path = @"C:\Users\Luka\Desktop\HotelDataPrint.txt";

        using var sw = new StreamWriter(path);

        foreach (var hotelData in hotelList)
        {
            sw.WriteLine("\n" + hotelData);
            Console.WriteLine($"Line has been written");
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

