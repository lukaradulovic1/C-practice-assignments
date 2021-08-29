using System;
using System.Collections.Generic;
//*MERGE: Inicijalizovati dva random celobrojna niza A i B,
//i pronaci njihov presek - ispisati sve elemente koji se pojavljuju u oba niza,
//ali u RASTUCEM redosledu i bez ponavljanja elementa

public class Program
{
	public static void Main()
	{
		// initialize array one 
		Console.WriteLine("Unesite broj elemenata prvog niza: ");
		int n1 = int.Parse(Console.ReadLine());
		
		int[] array = new int[n1];
		Random rnd = new Random();

		// initialize array two
		Console.WriteLine("Unesite broj elemenata prvog niza: ");
		int n2 = int.Parse(Console.ReadLine());

        int[] arrayTwo = new int[n2];
        Random rnd2 = new Random();


		// print initial array one
		Console.WriteLine("---------------\n\n\n" + "Nasumicni brojevi prvog niza su:");
		for (int i = 0; i < n1; i++)
		{
			array[i] = rnd.Next(0, 20);
			Console.WriteLine("---------------\n" + array[i]);
		}

		// print initial array two
		Console.WriteLine("---------------\n\n\n" + "Nasumicni brojevi drugog niza su:");
		for (int i = 0; i < n2; i++)
		{
			arrayTwo[i] = rnd2.Next(0, 20);
			Console.WriteLine("---------------\n" + arrayTwo[i]);
		}

		// sort array one 
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

		// sort array two 
		int temp2 = 0;
		for (int i = 0; i < arrayTwo.Length - 1; i++)
		{
			for (int j = i + 1; j > 0; j--)

			{
				if (arrayTwo[j - 1] > arrayTwo[j])
				{
					temp2 = arrayTwo[j - 1];
					arrayTwo[j - 1] = arrayTwo[j];
					arrayTwo[j] = temp2;

				}
			}
		}

		// print sorted array one 
		Console.WriteLine("---------------\n\n\nPoredjani brojevi prvog niza su: ");
		for (int i = 0; i < n1; i++)
		{
			Console.WriteLine("---------------\n" + array[i]);
		}

		// print sorted array two
		Console.WriteLine("---------------\n\n\nPoredjani brojevi drugog niza su: ");
		for (int i = 0; i < n2; i++)
		{
			Console.WriteLine("---------------\n" + arrayTwo[i]);
		}


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

		//initialize array three 
		int[] arrayThree = new int[n3];
		int x = 0;



		// separate same numbers from two arrays and put in array three 

		for (int i = 0; i < array.Length; i++)
			for (int j = 0; j < arrayTwo.Length; j++)
			{
				if (array[i] == arrayTwo[j])
				{
					arrayThree[x] = array[i];
					x++;
				}
			}



		// sort array three
		int temp3 = 0;
		for (int i = 0; i < arrayThree.Length - 1; i++)
		{
			for (int j = i + 1; j > 0; j--)

			{
				if (arrayThree[j - 1] > arrayThree[j])
				{
					temp3 = arrayThree[j - 1];
					arrayThree[j - 1] = arrayThree[j];
					arrayThree[j] = temp3;

				}
			}
		}



		Console.WriteLine("\n");


		for (int i = 0; i < n3; i++)
		{
			Console.WriteLine("Treci niz brojeva je:" + arrayThree[i]);
		}
	}
}