using System;
//FLIP: Random celobrojni niz ispisati u obrnutom redosledu
namespace djole_array_zadatak4
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
                nizBrojeva[j] = rnd.Next(0, 100);
                Console.WriteLine("\n" + nizBrojeva[j]);
            }

            Console.WriteLine(" \n-----------------------");

            for (int l = nizBrojeva.Length - 1; l >= 0; l--)
            {
                Console.WriteLine("\n" + nizBrojeva[l]);

            }
        }
    }
}





