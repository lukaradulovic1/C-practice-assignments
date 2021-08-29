using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder
{
   public class House
    {
        private readonly int numberOfFloors;
        private readonly int numberOfRoomsPerFloor;
        private readonly List<HouseFloor> houseFloors;

        public House(int numberOfFloors, int numberOfRoomsPerFloor)
        {
            this.numberOfFloors = numberOfFloors;
            this.numberOfRoomsPerFloor = numberOfRoomsPerFloor;
            houseFloors = new();

            for (int currentFloorNumber = 0; currentFloorNumber < numberOfFloors; currentFloorNumber++)
            {
                houseFloors.Add(new HouseFloor(currentFloorNumber, numberOfRoomsPerFloor));
            }
        }

        public void AddRoom(int floorNumber, Room room)
        {
            var houseFloor = houseFloors[floorNumber];
            houseFloor.AddRoom(room);
        }

        public override string ToString()
        {
            var str = $"House has {numberOfFloors} floors and {numberOfRoomsPerFloor} rooms per floor. ";
            for (int i = 0; i < houseFloors.Count; i++)
            {
                str += "\n";
                str += houseFloors[i];
            }
            return str;
        }

    }
}
