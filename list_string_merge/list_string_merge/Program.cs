using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //deklasiranje random list vrednosti za buduci list
        List <string> stringList = new List<string>{"zero", "one","two","three","four","five",
                                "six","seven","eight","nine", "ten",
                                "eleven","twelve","thirteen","fourteen","fifteen",
                                "sixteen", "seventeen","eighteen","nineteen","twenty"};

        Console.WriteLine("Unesite broj elemenata za listu: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        List<string> randomStringList1 = new List<string>();
        int r = 0;

        List<string> randomStringList2 = new List<string>();


        //biranje random vrednosti liste 1
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);
            randomStringList1.Add(stringList[r]);
            

        }

        // random  vrednosti liste 2
        for (int i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringList2.Add(stringList[r]);

        }

        // ispis prve liste
        Console.WriteLine("Prvi niz je:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringList1[i]);
        }

        Console.WriteLine("\n");

        //ispis niza drugog
        Console.WriteLine("\nDrugi niz je:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringList2[i]);
        }

        //pravljenje finalne liste
        List <string> finalList = new List<string>();

        for (int i = 0; i < n; i++)
        {
            finalList.Add(randomStringList1[i] + " " + randomStringList2[i]);
        }

        Console.WriteLine("\nVrednosti finalnog lista su: ");


        //ispis finalne liste
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(finalList[i]);
        }
    }
}

