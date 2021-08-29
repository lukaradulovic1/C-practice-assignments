using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {


        //deklasiranje random niz vrednosti za buduci niz
        List<string> stringList = new List<string> {"zero", "one","two","three","four","five",
                                "six","seven","eight","nine", "ten",
                                "eleven","twelve","thirteen","fourteen","fifteen",
                                "sixteen", "seventeen","eighteen","nineteen","twenty"};

        Console.WriteLine("Unesite broj elemenata za niz: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        List<string> randomStringList = new List<string>();
        int r = 0;


        //biranje random vrednosti
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringList.Add(stringList[r]);

        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringList[i]);
        }

        Console.WriteLine("Unesite string za proveru od gorenavedenih reci: ");
        string SubString = Console.ReadLine();

        List<string> finalResultList = new List<string>();

        int k = 0;

        for (int i = 0; i < n; i++)
        {
            if (randomStringList[i].Contains(SubString))
            {

                
                finalResultList.Add(randomStringList[i]);
                
            }
        }

        Console.WriteLine();

        for (k = 0; k < finalResultList.Count; k++)
        {
            Console.WriteLine(finalResultList[k]);

        }
    }
}

