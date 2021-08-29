using System;


class Program
{
    static void Main()
    {

        Console.WriteLine("Unesite broj elemenata niza: ");
        int size = int.Parse(Console.ReadLine());


		int[] array = CreateRandomIntArray(size);
		Console.WriteLine("Random integer array is: ");
		PrintIntArray(array);
		Console.WriteLine("Sorted random integer array is: ");
		SortIntArray(array);
		PrintIntArray(array);
		Console.WriteLine("Sorted random integer array without duplicates is: ");
		int[] uniqueArray=RemoveDuplicateIntegersFromArray(array);
		PrintIntArray(uniqueArray);


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

	private static void SortIntArray(int[] array)
	{

		for (var firstUnsorted = 0; firstUnsorted < array.Length; firstUnsorted++)
		{
			int minIndex = FindMinIndex(array, firstUnsorted);

			SwapElements(array, minIndex, firstUnsorted);

		}
		
	}

	private static int FindMinIndex(int[] array, int firstUnsorted)
	{
		var minIndex = firstUnsorted;
		for (var i = firstUnsorted; i < array.Length; i++)
		{
			var current = array[i];
			if (current < array[minIndex])
			{
				minIndex = i;
			}
		}
		return minIndex;
	}

	private static void SwapElements(int[] array, int minIndex, int firstUnsorted)
	{
		var temp = array[firstUnsorted];
		array[firstUnsorted] = array[minIndex];
		array[minIndex] = temp;
	}


	private static int[] RemoveDuplicateIntegersFromArray(int[] array)
    {

		int counter = 0;
		for (int i = 1; i < array.Length; i++)
		{
			if (array[i] != array[i - 1])
			{
				counter++;
			}

		}
		int[] removedDuplicatesArray = new int[counter];

		for (int i = 1; i < removedDuplicatesArray.Length; i++)
		{
			if (array[i] != array[i - 1])
			{
				removedDuplicatesArray[i] = array[i];
			}
		}
		return removedDuplicatesArray;
		
	}

	public static void PrintIntArray(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine("\n Array is: " + array[i]);
		}
	}

	

}



