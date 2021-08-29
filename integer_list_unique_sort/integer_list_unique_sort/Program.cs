using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite broj elemenata niza: ");
        int n = int.Parse(Console.ReadLine());
        List<int> listNumbers = new List<int>();
        
        Random rnd = new Random();
        Console.WriteLine("\n");

        for (int i = 0; i < n; i++)
        {
            listNumbers.Add(rnd.Next(0, 20));
            Console.WriteLine("Random brojevi niza su: " + listNumbers[i]);
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

            var temp = listNumbers[firstUnsorted];
            listNumbers[firstUnsorted] = listNumbers[minIndex];
            listNumbers[minIndex] = temp;

        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(listNumbers[i]);
        }

        Console.WriteLine(listNumbers[0]);

        for (int i = 1; i < n; i++)
        {
            if (listNumbers[i] != listNumbers[i - 1])
            {

                Console.WriteLine(" " + listNumbers[i]);
            }

        }


    }

}



//for (var i = 0; i < n; i++)
//{
//    for (var j=i+1; j<n; j++)
//    Console.Write(array[i] + " ");
//}


















