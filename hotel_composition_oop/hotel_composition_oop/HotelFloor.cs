using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class HotelFloor
{
    private int floorNumber;

    private List<HotelRoom> hotelRooms;

    public HotelFloor(int floorNumber)
    {
        this.FloorNumber = floorNumber;
        hotelRooms = new();
    }

    public int FloorNumber { get; }

    public void AddRoomsToFloor(int floorNumber, HotelRoom room)
    {
        hotelRooms.Add(room);
    }

    public void RemoveRoomFromFloor(int floorNumber, int roomNumber)
    {
        foreach (var currentRoom in this.hotelRooms.ToList())
        {
            if(currentRoom.FloorNumber == floorNumber&& currentRoom.RoomNumber == roomNumber)
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

