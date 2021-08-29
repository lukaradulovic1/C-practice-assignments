using System;



public class Program
{
	public static void Main()
	{

		// initialize array one 
		Console.WriteLine("Unesite broj elemenata prvog niza: ");
		int n1 = int.Parse(Console.ReadLine());

		int[] array= CreateRandomIntArray(n1);
		

		// initialize array two
		Console.WriteLine("Unesite broj elemenata prvog niza: ");
		int n2 = int.Parse(Console.ReadLine());


		int[] arrayTwo = CreateRandomIntArray(n2);

		// print initial array one
		Console.WriteLine("---------------\n\n\n" + "Nasumicni brojevi prvog niza su:");
		PrintIntArray(array);

		// print initial array two
		Console.WriteLine("---------------\n\n\n" + "Nasumicni brojevi drugog niza su:");
		PrintIntArray(arrayTwo);

		SortIntArray(array);

		SortIntArray(arrayTwo);

	
		// print sorted array one 
		Console.WriteLine("---------------\n\n\nPoredjani brojevi prvog niza su: ");
		PrintIntArray(array);

		// print sorted array two
		Console.WriteLine("---------------\n\n\nPoredjani brojevi drugog niza su: ");
		PrintIntArray(arrayTwo);

		int[] arrayThree = MergeIntArrays(array, arrayTwo);

		SortIntArray(arrayThree);

		Console.WriteLine("Spojeni niz je: ");

		PrintIntArray(arrayThree);

	}
	private static int[] MergeIntArrays(int[] array, int[] arrayTwo)
    {
		int n3 = CalculateMergedArraySize(array, arrayTwo);
		//initialize array three 
		int[] arrayThree = new int[n3];
		FillArrayWithMergedValues(array, arrayTwo, arrayThree);

		return arrayThree;
	}

	private static void FillArrayWithMergedValues(int[] array, int[] arrayTwo, int[] arrayThree)
	{
				// separate same numbers from two arrays and put in array three 
		int x = 0;
		for (int i = 0; i < array.Length; i++)
			for (int j = 0; j < arrayTwo.Length; j++)
			{
				if (array[i] == arrayTwo[j])
				{
					arrayThree[x] = array[i];
					x++;
				}
			}
	}

	private static int CalculateMergedArraySize(int[] array, int[] arrayTwo)
    {
		//declaring size of the array three 
		int n3 = 0;
		for (int i = 0; i < array.Length; i++)
			for (int j = 0; j < arrayTwo.Length; j++)
			{
				if (array[i] == arrayTwo[j])
				{
					n3++;
				}
			}
		return n3;
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

	public static void PrintIntArray(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine("Integer array is: " + array[i]);
		}
	}

}