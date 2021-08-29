using System;
using composition_test;

namespace composition_test
{
    class Program
    {
        static void Main()
        {
        var largeBox = new LargeBox();
            largeBox.PrintSize();
            largeBox.AddBoxes();
            Console.WriteLine();
            largeBox.PrintSize();
        }
    }
}
