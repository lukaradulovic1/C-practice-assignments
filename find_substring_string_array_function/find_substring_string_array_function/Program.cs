using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Type in number of elements for the array ");
        int size = int.Parse(Console.ReadLine());
        string[] array = CreateRandomStringArray(size);
        Console.WriteLine("Random strings are: ");
        PrintStringArray(array);

        Console.WriteLine("Input substring to search for: ");
        string substring = Console.ReadLine();

        Console.WriteLine("Found strings which contain the substring: ");
        
        string[] substringArray = FindSubstring(substring, array);
        PrintStringArray(substringArray);
    }




    private static string[] FindSubstring(string substring, string[] array)
    {
        // velicina novog niza
        int arraySize = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Contains(substring))
            {
                arraySize++;
            }
        }

        //novi niz za store 
        string[] newArray = new string[arraySize];

        int k = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Contains(substring))
            {

                newArray[k] = array[i];
                k++;
            }
        }

        return newArray;

    }

    static void PrintSubstringArray(string[] newArray)
    {

        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }

    static void PrintStringArray(string[] array)
    {

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    static string[] CreateRandomStringArray(int size)
    {
        //deklasiranje random niz vrednosti za buduci niz
        string[] stringArray = {"zero", "one","two","three","four","five",
                                "six","seven","eight","nine", "ten",
                                "eleven","twelve","thirteen","fourteen","fifteen",
                                "sixteen", "seventeen","eighteen","nineteen","twenty"};



        Console.WriteLine();

        string[] array = new string[size];
        int r = 0;


        //biranje random vrednosti
        Random rnd = new Random();
        for (int i = 0; i < size; i++)
        {

            r = rnd.Next(0, 20);

            array[i] = stringArray[r];

        }
        return array;
    }
}


