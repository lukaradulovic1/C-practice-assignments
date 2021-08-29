using System;
/*
INITIALIZE: Procitati celi broj N sa ulaza, 
inicijalizovati niz od N elemenata - celih random brojeva izmedju 0 i 20, 
i ispisati taj niz
 */
namespace djole_array_zadatak1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite broj elemenata niza: ");
            int i = int.Parse(Console.ReadLine());
            int[] nizBrojeva = new int[i];
            Random rnd = new Random();


            for (int j = 0; j < i; j++)
            {
                nizBrojeva[j] = rnd.Next(0,20);
                Console.WriteLine("\n" + nizBrojeva[j]);
            }
        }
    }
}
