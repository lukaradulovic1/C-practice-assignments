using System;
//* INITIALIZE: Procitati celi broj N sa ulaza,
//inicijalizovati niz od N elemenata - stringova koji sadrze verbalnu reprezentaciju random brojeva izmedju 0 i 20
//- "nula", "jedan", "dva", ...

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
    }
    }

