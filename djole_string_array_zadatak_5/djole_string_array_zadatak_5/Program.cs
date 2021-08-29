using System;
//*FIND_SUBSTRING: Procitati string S sa ulaza,
//pronaci SVA pojavljivanja elemenata koji SADRZI u sebi string S,
//i ispisati te elemente u originalnom redosledu (npr S="est", a ispise se "sedamnaest, jedanaest")

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

        string[] randomStringArray = new string[n];
        int r = 0;


        //biranje random vrednosti
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringArray[i] = stringArray[r];

        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringArray[i]);
        }

        Console.WriteLine("Unesite string za proveru od gorenavedenih reci: ");
        string SubString = Console.ReadLine();

        // velicina novog niza
        int arraySize = 0;

        

        for (int i = 0; i < n; i++)
        {
            if (randomStringArray[i].Contains(SubString))
            {
                arraySize++;
            }
        }

        //novi niz za store 
        string[] newArray = new string[arraySize];

        int k = 0;

        for (int i = 0; i < n; i++)
        {
            if (randomStringArray[i].Contains(SubString))
            {
                
                newArray[k] = randomStringArray[i];
                k++;
            }
        }

        Console.WriteLine();

        for (k = 0; k < arraySize; k++)
        {
        Console.WriteLine(newArray[k]);

        }
    }
}

