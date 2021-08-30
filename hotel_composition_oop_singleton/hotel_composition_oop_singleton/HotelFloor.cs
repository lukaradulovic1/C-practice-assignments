using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class HotelFloor
{
    private readonly int floorNumber;

    private readonly List<HotelRoom> hotelRooms;

    public HotelFloor(int floorNumber)
    {
        this.floorNumber = floorNumber;
        hotelRooms = new();
    }

    public int FloorNumber
    {
        get
        {
            return floorNumber;
        }
    }

    public void AddRoom(HotelRoom room)
    {
        hotelRooms.Add(room);
    }

    public void RemoveRoom(int roomNumber)
    {
        foreach (var currentRoom in this.hotelRooms.ToList())
        {
            if (currentRoom.RoomNumber == roomNumber)
            {
                hotelRooms.Remove(currentRoom);
                Console.WriteLine($"{currentRoom} has been removed");
            }
        }
    }



    public override string ToString()
    {
        string str = "";
        foreach (var room in hotelRooms)
        {
            str += room.ToString();
        }
        return str;
    }

}

