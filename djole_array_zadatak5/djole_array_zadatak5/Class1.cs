using System;

public static class Program
{
	public static void Main()
	{
		// INIT ARRAY
		Console.WriteLine("enter a number hi");
		var n = int.Parse(Console.ReadLine());
		var array = new int[n];
		var random = new Random();
		for (var i = 0; i < n; i++)
		{
			array[i] = random.Next(0, 20);
			Console.Write(array[i] + " ");
		}

		Console.WriteLine("");

		for (var firstUnsorted = 0; firstUnsorted < n; firstUnsorted++)
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


			var temp = array[firstUnsorted];
			array[firstUnsorted] = array[minIndex];
			array[minIndex] = temp;

		}


		for (var i = 0; i < n; i++)
		{
			Console.Write(array[i] + " ");
		}
	}
}