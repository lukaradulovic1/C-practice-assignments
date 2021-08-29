using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Type in number of elements to be put in the converted to a list: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = CreateRandomIntArray(size);
        List<int> intList = ConvertArrayToList(array);
        PrintIntList(intList);

        }

    public static int[] CreateRandomIntArray(int size)
    {
        int[] array = new int[size];
        var random = new Random();

        for (var i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 20);
        }
        return array;
    }

    private static List<int> ConvertArrayToList (int [] array)
    {
        List<int> intList = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            intList.Add(array[i]);
        }
        return intList;
    }
    public static void PrintIntList(List <int> intList)
    {
        for (int i = 0; i < intList.Count; i++)
        {
            Console.WriteLine("Integer list is: " + intList[i]);
        }
    }
}
