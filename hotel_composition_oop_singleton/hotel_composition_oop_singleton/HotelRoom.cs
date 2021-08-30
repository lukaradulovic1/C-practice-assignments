using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class HotelRoom
{
    private readonly int floorNumber;
    private readonly int roomNumber;
    private readonly int guestNumber;
    private readonly OccupancyStatus occupancyStatus;
    private readonly int durationOfStay;
    private readonly RoomType roomType;


    public HotelRoom(int floorNumber, int roomNumber, int guestNumber, OccupancyStatus occupancyStatus, int durationOfStay, RoomType roomType)
    {
        this.floorNumber = floorNumber;
        this.roomNumber = roomNumber;
        this.guestNumber = guestNumber;
        this.occupancyStatus = occupancyStatus;
        this.durationOfStay = durationOfStay;
        this.roomType = roomType;
    }

    public int FloorNumber => floorNumber;

    public int RoomNumber => roomNumber;

    public override string ToString()
    {
        return $"\nFloor number: {FloorNumber}\nRoom number: {RoomNumber}\nGuest(s) number: {guestNumber}\nOccupancy status: {occupancyStatus}.\nDuration of stay is {durationOfStay} day(s).\nRoom type: {roomType}";
    }

}