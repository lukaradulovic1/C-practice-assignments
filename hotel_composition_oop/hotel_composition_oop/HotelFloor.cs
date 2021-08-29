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

    public void AddRoomsToFloor(HotelRoom room)
    {
        hotelRooms.Add(room);
    }

    public void RemoveRoomFromFloor(int floorNumber, int roomNumber)
    {
        foreach (var currentRoom in this.hotelRooms.ToList())
        {
            if (currentRoom.FloorNumber == floorNumber && currentRoom.RoomNumber == roomNumber)
            {
                hotelRooms.Remove(currentRoom);
                Console.WriteLine($"{currentRoom} has been removed");
            }
        }
    }

    public void HotelRoomPrint()
    {
        foreach (var room in hotelRooms)
        {
            Console.WriteLine(room.ToString());
        }
    }


}

