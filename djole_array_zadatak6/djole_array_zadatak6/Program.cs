using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite broj elemenata niza: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Random rnd = new Random();
        Console.WriteLine("\n");

        for (int i = 0; i < n; i++)
        {
            array[i] = rnd.Next(0, 20);
            Console.WriteLine("Random brojevi niza su: " + array[i]);
        }

        for (int firstUnsorted = 0; firstUnsorted < n; firstUnsorted++)
        {
            var minIndex = firstUnsorted;
            for (var i = firstUnsorted; i < n; i++)
            {
                var current = array[i];

                if (current < array[minIndex])
                {
                    minIndex = i;
                }
            }

            var temp = firstUnsorted;
            array[firstUnsorted] = array[minIndex];
            array[minIndex] = temp;

        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("nulti clan niza je " + array[0]); 

        for (int i = 1; i < n; i++)
        {
            if (array[i] != array[i - 1])
                {
                    
                    Console.WriteLine(" " + array[i]);
                }
            
        }


    }

}



    //for (var i = 0; i < n; i++)
    //{
    //    for (var j=i+1; j<n; j++)
    //    Console.Write(array[i] + " ");
    //}


















