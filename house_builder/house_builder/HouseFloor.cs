using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder
{
   public class HouseFloor
    {
        private readonly int floorNumber;
        private readonly int numberOfRooms;
        private List<Room> rooms;
        
        public HouseFloor(int floorNumber, int numberOfRooms)
        {
            this.floorNumber = floorNumber;
            this.numberOfRooms = numberOfRooms;
            rooms = new();
        }

        public void AddRoom(Room room)
        {
            if (numberOfRooms == rooms.Count)
            {
                throw new Exception("Max rooms reached! No bueno for now.");
            }
            else
            {
                rooms.Add(room);
            }
        }

        public override string ToString()
        {
            var str = $"Floor number is {floorNumber} with {numberOfRooms} rooms on it.";
            for (int i = 0; i < rooms.Count; i++)
            {
                str += "\n";
                str += rooms[i];
            }
            return str;
        }
    }
}
