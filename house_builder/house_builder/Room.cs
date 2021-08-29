using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house_builder
{ 
   public class Room
    {
        private readonly int numberOfWindows;
        private readonly int roomSizeSquareMeters;
        private readonly int bedNumber;
        


        public Room(int numberOfWindows, int roomSizeSquareMeters, int bedNumber)
        {
            this.numberOfWindows = numberOfWindows;
            this.roomSizeSquareMeters = roomSizeSquareMeters;
            this.bedNumber = bedNumber;
            
        }

        public override string ToString()
        {
            return $"Room has {numberOfWindows} windows, size is {roomSizeSquareMeters} with {bedNumber} bed/s ";
        }

    }
}
