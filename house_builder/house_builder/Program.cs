using System;

namespace house_builder
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("type in floor and room limits of the house");
            var fNumber = int.Parse(Console.ReadLine());
            var roomNum= int.Parse(Console.ReadLine());
            var house = new House(fNumber, roomNum);
            while (true)
            {
                

                Console.WriteLine("Type in number of windows the room has:");
                var numberOfWindows = int.Parse(Console.ReadLine());
                Console.WriteLine("Type in the size of the room in square meters: ");
                var squareMeters = int.Parse(Console.ReadLine());
                Console.WriteLine("Type in the number of beds in the room: ");
                var bedNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Type in floor of the house youre building: ");
                var floor = int.Parse(Console.ReadLine());
                
                Room room = new Room(numberOfWindows, squareMeters, bedNumber);
                house.AddRoom(floor, room);

                Console.WriteLine(house);
            }

        }
    }
}
