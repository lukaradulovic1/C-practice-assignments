using System;
//*MERGE: Inicijalizovati dva random string niza A i B,
//ISTIH DUZINA, pa izracunati string niz C koji se dobija kad se elementi nizova A i B dopisu sa razmakom izmedju
//(npr A=["tri", "dvanaest"], B =["sedam", "nula"],
//C treba da bude ["tri sedam", "dvanaest nula"])

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

        string[] randomStringArray1 = new string[n];
        int r = 0;

        string[] randomStringArray2 = new string[n];


        //biranje random vrednosti
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringArray1[i] = stringArray[r];

        }

       // random niz vrednosti niza 2
        for (int i = 0; i < n; i++)
        {

            r = rnd.Next(0, 20);

            randomStringArray2[i] = stringArray[r];

        }

        // ispis niza prvog
        Console.WriteLine("Prvi niz je:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringArray1[i]);
        }

        Console.WriteLine("\n");

        //ispis niza drugog
        Console.WriteLine("\nDrugi niz je:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(randomStringArray2[i]);
        }

        //pravljenje finalnog niza
        string[] finalArray = new string [n];

        for (int i = 0; i < n; i++)
        {
            finalArray[i] = randomStringArray1[i] + " " + randomStringArray2[i];
        }

        Console.WriteLine("\nVrednosti finalnog niza su: ");


        //ispis finalnog niza
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(finalArray[i]);
        }
    }
}

