using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Unesite broj elemenata niza: ");
        int n = int.Parse(Console.ReadLine());
        List<int> listNumbers = new List<int> ();
        Random rnd = new Random();
        Console.WriteLine("\n");

        for (int i = 0; i < n; i++)
        {
            listNumbers.Add(rnd.Next(0, 20));
            Console.WriteLine("Random brojevi liste su: " + listNumbers[i]);
        }

        for (int firstUnsorted = 0; firstUnsorted < n; firstUnsorted++)
        {
            var minIndex = firstUnsorted;
            for (var i = firstUnsorted; i < n; i++)
            {
                var current = listNumbers[i];

                if (current < listNumbers[minIndex])
                {
                    minIndex = i;
                }
            }

            var temp = firstUnsorted;
            listNumbers[firstUnsorted] = listNumbers[minIndex];
            listNumbers[minIndex] = temp;

        }

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (listNumbers[i] == listNumbers[j])
                {

                    Console.WriteLine("Random unique numbers sorted are: " + listNumbers[i]);
                }
            }
        }


    }

}



















