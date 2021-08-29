using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        bool showMainMenu = true;

        var hotel = new Hotel();
        List<HotelRoom> hotelSpecList = new List<HotelRoom>();
       
        var path = @"C:\Users\Luka\Desktop\HotelDataPrint.txt";
        while (showMainMenu)
        {
            
            Console.WriteLine("Press 1 to create room.\nPress 2 to remove room.\nPress 3 to print hotel specifications.\nPress 4 to print hotel specifications to txt file.\nPress 5 to clear all.\nPress 6 to exit.\n");
            string inputKey = Console.ReadLine();

           

            switch (inputKey)
            {
                //add room
                case "1":
                    {
                        Console.WriteLine("Type in the floor number that you would like to settle the guest or guests in: ");
                        var floorNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type in the room number you would like to settle the guest or guests in: ");
                        var roomNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type in the number of occupants for said room: ");
                        var guestNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type in if you want the room to be occupied or unoccupied.");
                        OccupancyStatus occupancyStatus = (OccupancyStatus)Enum.Parse(typeof(OccupancyStatus), Console.ReadLine());
                        Console.WriteLine("Type in the lenght of stay: (0 makes room unoccupied and waiting on guest, 1+ makes it occupied.");
                        var durationOfStay = int.Parse(Console.ReadLine());
                        Console.WriteLine("Type in the room type for the guest or guests: \nSingle\nDouble\nTriple\nQuad\nQueen\nKing\nTwin\nDoubledouble\nStudio");
                        Console.WriteLine();
                        var roomType = (RoomType)Enum.Parse(typeof(RoomType), Console.ReadLine());
                        var room = new HotelRoom(floorNumber, roomNumber, guestNumber, occupancyStatus, durationOfStay, roomType);
                        hotel.AddRoom(floorNumber, room);
                        hotelSpecList.Add(room);
                        showMainMenu = true;
                        break;
                    }

                // remove room
                case "2":
                    {
                        Console.WriteLine("Available rooms are: \n");
                        hotel.PrintHotelSpec();
                        Console.WriteLine("Type in the number of the floor and room you would like to remove");
                        var floorNumber = int.Parse(Console.ReadLine());
                        var roomNumber = int.Parse(Console.ReadLine());
                        hotel.RemoveRoom(floorNumber, roomNumber);
                        showMainMenu = true;
                        break;
                    }
                // print hotel spec

                case "3":
                    {
                        hotel.PrintHotelSpec();
                        showMainMenu = true;
                        Console.WriteLine();
                        break;
                    }
                //write  hotel spec to txt
                case "4":
                    {
                        hotel.PrintHotelFile(path);
                        showMainMenu = true;
                        break;
                    }
                // clear entire hotel
                case "5":
                    {
                        hotel.ClearAllData();
                        showMainMenu = true;
                        break;
                    }
                case "6":
                    showMainMenu = false;
                    break;

                default:
                    Console.WriteLine("You have made a wrong input, try again.");
                    Console.WriteLine();
                    showMainMenu = true;
                    break;
            }

        }
    }
}
