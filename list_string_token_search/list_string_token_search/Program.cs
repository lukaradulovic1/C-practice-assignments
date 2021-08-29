using System;
using System.Collections.Generic;
//* TOKEN_SEARCH (hell): Procitati string S sa ulaza, koji u sebi moze imati razmake (npr S="va ve"),
//pretraziti niz finalArray iz MERGE zadatka za sve elemente koji SADRZE u sebi BILO KOJU OD RECI iz stringa S,
//i ispisati te elemente u originalnom redosledu, npr "dvanaest devet", "dva nula", "devetnaest sedam")

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
        List<string> randomStringList1 = new List<string>();
       
        var r = 0;

        List<string> randomStringList2 = new List<string>();


        //biranje random vrednosti prve liste
        var rnd = new Random();
        for (var i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringList1.Add(stringList[r]);

        }

        //biranje random vrednosti druge liste
        for (var i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringList2.Add(stringList[r]);

        }

        // ispis prve liste
        Console.WriteLine("Prvi niz je:");
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringList1[i]);
        }

        Console.WriteLine("\n");

        //ispis  druge liste
        Console.WriteLine("\nDrugi niz je:");
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringList2[i]);
        }

        //pravljenje konacne liste
        
        List<string> finalList = new List<string>();

        for (var i = 0; i < n; i++)
        {
            finalList.Add(randomStringList1[i] + " " + randomStringList2[i]);
        }

        Console.WriteLine("\nVrednosti finalnog niza su: \n");


        //ispis konacne liste
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(finalList[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Unesite vrednosti za pretragu: ");
        Console.WriteLine();
        string searchString = Console.ReadLine();
        Console.WriteLine();

        var searchWords = searchString.Split(' ');

        //ispis bez duplikata u listi
        for (var i = 0; i < n; i++)
            for (var j = 0; j < searchWords.Length; j++)
            {

                if (finalList[i].Contains(searchWords[j]))
                {
                    Console.WriteLine(finalList[i]);
                    break;
                }


            }
    }

}

