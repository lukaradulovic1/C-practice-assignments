using System;
//* FIND_INDEX: Procitati string S sa ulaza,
//pronaci PRVO pojavljivanje takvog stringa u random string nizu,
//i ispisati INDEKS njegovog prvog pojavljivanja

class Program
{
    static void Main(string[] args)
    {

        string[] stringArray = {"zero", "one","two","three","four","five",
                                "six","seven","eight","nine", "ten",
                                "eleven","twelve","thirteen","fourteen","fifteen",
                                "sixteen", "seventeen","eighteen","nineteen","twenty"};

        Console.WriteLine("Unesite broj elemenata niza vrednosti 1-20: ");
        int n = int.Parse(Console.ReadLine());

        string[] randomStringArray = new string[n];
        int r = 0;

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
        string S = Console.ReadLine();

        int l = 0;

        for (int i = n - 1; i >= 0; i--) 
        {
            if (S == randomStringArray[i])
            {
                l = i;
                break;
            }
        }

        Console.WriteLine("\n" + l);


    }
}

