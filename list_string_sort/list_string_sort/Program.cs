using System;
using System.Collections.Generic;

//*SORT: Random string niz ispisati u abecednom redosledu

class Program
{
    static void Main()
    {

        List<string> stringList = new List<string>  {
                                                     "zero", "one","two","three","four","five",
                                                     "six","seven","eight","nine", "ten",
                                                     "eleven","twelve","thirteen","fourteen","fifteen",
                                                     "sixteen", "seventeen","eighteen","nineteen","twenty"};

        Console.WriteLine("Unesite broj elemenata niza vrednosti 1-20: ");
        int n = int.Parse(Console.ReadLine());
        List<string> randomStringList = new List<string>();

        int r = 0;

        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            r = rnd.Next(0,20);
           
            randomStringList.Add(stringList[r]);
        }

        randomStringList.Sort();
            

        for (int i = 0; i < n; i++)
        {

            Console.WriteLine(randomStringList[i]);
        }
    }
}

