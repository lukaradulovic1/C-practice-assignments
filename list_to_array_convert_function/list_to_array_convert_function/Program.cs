using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Unesite broj elemenata u listu: ");
		int n = int.Parse(Console.ReadLine());
		List<int> intList = RandomListFunction(n);
		int[] array = ListToArrayConverter(intList);
		Console.WriteLine();
		Console.WriteLine("Converted list to array numbers are: ");
		PrintArrayFunction(array);

	}

	private static List<int> RandomListFunction(int n)
	{
		List<int> intList = new List<int>();

		Random rnd = new Random();

		for (int i = 0; i < n; i++)
		{
			intList.Add(rnd.Next(0, 20));
		}
		return intList;
	}

	private static int[] ListToArrayConverter(List<int> intList)
	{
		int intArraySize = intList.Count;


		int[] intArray = new int[intArraySize];

		for (int i = 0; i < intArray.Length; i++)
		{
			intArray[i] = intList[i];
		}

		return intArray;
	}

	private static void PrintArrayFunction(int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			Console.WriteLine(array[i]);

		}

	}
}