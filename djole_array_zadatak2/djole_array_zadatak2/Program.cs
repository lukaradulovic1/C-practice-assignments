using System;
/*
 * COUNT: Procitati celi broj K sa ulaza, 
 * izbrojati koliko se puta broj K ponavlja u random celobrojnom nizu, 
 * i ispisati odgovor
 */
namespace djole_array_zadatak2
{
    class Program
    {
        static void Main()
        {
            int brojac2 = 0;
            Console.WriteLine("Unesite broj elemenata niza: ");
            int i = int.Parse(Console.ReadLine()); //bira broj elemenata niza
            int[] nizBrojeva = new int[i]; // ubacuje gornji broj kao broj elemenata niza
            Random rnd = new Random(); //funkcija za stvaranje random broja



            for (int j = 0; j < i; j++) //i je zauzet, j je novi znak za inicijalizaciju niza
            {

                nizBrojeva[j] = rnd.Next(0, 20);
                Console.WriteLine("---------------\n" + nizBrojeva[j]);
            }

            Console.WriteLine("Unesite vrednost za broj K: ");
            int k = int.Parse(Console.ReadLine());
            int brojac = 0;
            for (int j = 0; j < i; j++)
            {
                if (nizBrojeva[j] == k)

                {

                    brojac++;
                    
                }

            }

            Console.WriteLine("Broj {0} se nalazi u nizu {1} put/puta", k, brojac);


        }
    }
}

