using System;

namespace converter_of_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in number of seconds to be converted to minutes/hours.");
            int inputSeconds = int.Parse(Console.ReadLine());

            int hours = inputSeconds / 3600;
            int minutes = (inputSeconds % 3600) / 60;
            Console.WriteLine($"You have {hours} hours and {minutes} minutes in {inputSeconds} seconds.");
        }
    }
}
