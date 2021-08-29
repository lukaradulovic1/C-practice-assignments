
//SUM: Procitati celi broj K sa ulaza,
//pronaci ZBIR svih elemenata iz random celobrojnog niza koji su DELJIVI sa K,
//i ispisati taj zbir
using System;

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
            int suma = 0;


            for (int j = 0; j < i; j++)
            
                {
                    nizBrojeva[j] = rnd.Next(0, 20);
                    Console.WriteLine("-------\n" + nizBrojeva[j]);
                }
                Console.WriteLine("Unesite vrednost k: ");
                int k = int.Parse(Console.ReadLine());

            for (int j = 0; j < i; j++)
                
                if (nizBrojeva[j] % k == 0)
                {
                    
                                        
                    suma += nizBrojeva[j];

                }

            Console.WriteLine("Suma zbira je {0}", suma);





        }
    }
}
