using System;
//* TOKEN_SEARCH (hell): Procitati string S sa ulaza, koji u sebi moze imati razmake (npr S="va ve"),
//pretraziti niz finalArray iz MERGE zadatka za sve elemente koji SADRZE u sebi BILO KOJU OD RECI iz stringa S,
//i ispisati te elemente u originalnom redosledu, npr "dvanaest devet", "dva nula", "devetnaest sedam")

class Program
{
    static void Main()
    {
        //deklasiranje random niz vrednosti za buduci niz
        string[] stringArray = {"zero", "one","two","three","four","five",
                                "six","seven","eight","nine", "ten",
                                "eleven","twelve","thirteen","fourteen","fifteen",
                                "sixteen", "seventeen","eighteen","nineteen","twenty"};

        Console.WriteLine("Unesite broj elemenata za niz: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        var randomStringArray1 = new string[n];
        var r = 0;

        var randomStringArray2 = new string[n];


        //biranje random vrednosti
        var rnd = new Random();
        for (var i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringArray1[i] = stringArray[r];

        }

        // random niz vrednosti niza 2
        for (var i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringArray2[i] = stringArray[r];

        }

        // ispis niza prvog
        Console.WriteLine("Prvi niz je:");
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringArray1[i]);
        }

        Console.WriteLine("\n");

        //ispis niza drugog
        Console.WriteLine("\nDrugi niz je:");
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringArray2[i]);
        }

        //pravljenje finalnog niza
        string[] finalArray = new string[n];

        for (var i = 0; i < n; i++)
        {
            finalArray[i] = randomStringArray1[i] + " " + randomStringArray2[i];
        }

        Console.WriteLine("\nVrednosti finalnog niza su: \n");


        //ispis finalnog niza
        for (var i = 0; i < n; i++)
        {
            Console.WriteLine(finalArray[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Unesite vrednosti za pretragu: ");
        Console.WriteLine();
        string searchString = Console.ReadLine();
        Console.WriteLine();

        var searchWords = searchString.Split(' ');

        //ispis bez duplikata
        for (var i = 0; i < n; i++)
            for (var j = 0; j < searchWords.Length; j++)
            {

                if (finalArray[i].Contains(searchWords[j]))
                {
                    Console.WriteLine(finalArray[i]);
                    break;
                }
                    

        }
    }
    
}

