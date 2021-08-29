using System;
//7. Ispisi 5 najmanjih brojeva koji kada se podele sa 3,4 i 5 daju ostatak nula.
namespace _5najmanjih
{
    class Program
    {
        static void Main(string[] args)
        {

            int rezultat = 0;
            for (int i = 1; i < 75625;  i++)
            {
                rezultat = i * i;
                Console.WriteLine(i);
                
            }
        }
    }
}
