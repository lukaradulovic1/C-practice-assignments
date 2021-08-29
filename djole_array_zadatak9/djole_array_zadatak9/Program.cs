using System;

//*MERGE: Inicijalizovati dva random celobrojna niza A i B,
//i pronaci njihov presek - ispisati sve elemente koji se pojavljuju u oba niza,
//ali u RASTUCEM redosledu i bez ponavljanja elementa


public class Program
{
	public static void Main()
	{
		// initialize array
		Console.WriteLine("Unesite broj elemenata niza: ");
		int n = int.Parse(Console.ReadLine());
		int[] array = new int[n];
		Random rnd = new Random();




		// print initial array
		Console.WriteLine("---------------\n\n\n" + "Nasumicni brojevi su:");
		for (int i = 0; i < n; i++)
		{
			array[i] = rnd.Next(0, 20);
			Console.WriteLine("---------------\n" + array[i]);
		}

		Console.WriteLine("Unesite broj za K: ");
		var k = int.Parse(Console.ReadLine());

		// sort array
		int temp = 0;
		for (int i = 0; i < array.Length - 1; i++)
		{
			for (int j = i + 1; j > 0; j--)

			{
				if (array[j - 1] > array[j])
				{
					temp = array[j - 1];
					array[j - 1] = array[j];
					array[j] = temp;

				}
			}
		}

		// print sorted array
		Console.WriteLine("---------------\n\n\nPoredjani brojevi su: ");
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine("---------------\n" + array[i]);
		}


		// GOOD ^



		// unique count
		int m = 0;
		if (n != 0)
		{
			m = 1;
			for (var i = 1; i < n; i++)
			{
				if (array[i - 1] != array[i] && array[i] % k == 0)
				{
					m++;
				}
			}
		}


		// array = [ 1 1 1 3 3 5 6 7 8 8 8 10 ]

		// m = 2


		// GOOD ^

		// newArray = [3,6]


		// k=3

		// ....

		// m = <broj razlicitih elemenata iz array>

		// unique array
		Console.WriteLine("---------------\n\n\nPoredjani brojevi po rastucim, nasumicni i bez duplikata koji su deljivi sa K: ");
		int[] newArray = new int[m];

		// GOOD ^

		if (n != 0)
		{
			newArray[0] = array[0];


			int p = 1;
			for (var i = 1; i < n; i++)
			{
				if (array[i - 1] != array[i] && array[i] % k == 0)
				{
					newArray[p] = array[i];
					p++;
				}
			}
		}


		// GOOD v

		// print unique array
		for (int i = 0; i < m; i++)
		{
			Console.WriteLine(newArray[i]);
		}

		int[] thirdArray = new int[n];
		int u = 0;
		for (int i = 0; i < array.Length - 1; i++)
		{
			for (int j = i + 1; j > 0; j--)
			{
				if (array[i] == newArray[j])
				{
					thirdArray[u] = array[i];
					u++;
				}

			}

			for (int x = 0; x < n; x++)
			{
				Console.WriteLine(thirdArray[x]);
			}


		}
	}
}
