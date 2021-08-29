using System;
using System.Collections.Generic;
//*MERGE: Inicijalizovati dva random celobrojna niza A i B,
//i pronaci njihov presek - ispisati sve elemente koji se pojavljuju u oba niza,
//ali u RASTUCEM redosledu i bez ponavljanja elementa

public class Program
{
	public static void Main()
	{
		// initialize list one 
		Console.WriteLine("Unesite broj elemenata prve liste: ");
		int n1 = int.Parse(Console.ReadLine());
		List<int> listaBrojeva = new List<int>();
		
		Random rnd = new Random();

		// initialize list two
		Console.WriteLine("Unesite broj elemenata druge liste: ");
		int n2 = int.Parse(Console.ReadLine());
		List<int> listaBrojeva2 = new List<int>();
		

		// print initial list one
		Console.WriteLine("---------------\n\n\n" + "Nasumicni brojevi prve liste su:");
		for (int i = 0; i < n1; i++)
		{
			listaBrojeva.Add(rnd.Next(0, 20));
			Console.WriteLine("---------------\n" + listaBrojeva[i]);
		}

		// print initial list two
		Console.WriteLine("---------------\n\n\n" + "Nasumicni brojevi druge liste su:");
		for (int i = 0; i < n2; i++)
		{
			listaBrojeva2.Add(rnd.Next(0, 20));
			Console.WriteLine("---------------\n" + listaBrojeva2[i]);
		}

		// sort list one 
		int temp = 0;
		for (int i = 0; i < n1 - 1; i++)
		{
			for (int j = i + 1; j > 0; j--)

			{
				if (listaBrojeva[j - 1] > listaBrojeva[j])
				{
					temp = listaBrojeva[j - 1];
					listaBrojeva[j - 1] = listaBrojeva[j];
					listaBrojeva[j] = temp;

				}
			}
		}

		// sort list two 
		
		for (int i = 0; i < n2 - 1; i++)
		{
			for (int j = i + 1; j > 0; j--)

			{
				if (listaBrojeva2[j - 1] > listaBrojeva2[j])
				{
					temp = listaBrojeva2[j - 1];
					listaBrojeva2[j - 1] = listaBrojeva2[j];
					listaBrojeva2[j] = temp;

				}
			}
		}

		// print sorted list one 
		Console.WriteLine("---------------\n\n\nPoredjani brojevi prvog niza su: ");
		for (int i = 0; i < n1; i++)
		{
			Console.WriteLine("---------------\n" + listaBrojeva[i]);
		}

		// print sorted list two
		Console.WriteLine("---------------\n\n\nPoredjani brojevi drugog niza su: ");
		for (int i = 0; i < n2; i++)
		{
			Console.WriteLine("---------------\n" + listaBrojeva2[i]);
		}




		//initialize list three 
		List<int> listaBrojeva3 = new List<int>();




		// separate same numbers from two lists and put in list three 
		for (int i = 0; i < n1; i++)
			for (int j = 0; j < n2; j++)
			{
				if (listaBrojeva[i] == listaBrojeva2[j])
				{
					listaBrojeva3.Add(listaBrojeva[i]);
					
				}
			}

		Console.WriteLine("Treca lista brojeva je : " + listaBrojeva3.Count);

		// sort list three
		
		for (int i = 0; i < listaBrojeva3.Count - 1; i++)
		{
			for (int j = i + 1; j > 0; j--)

			{
				if (listaBrojeva3[j - 1] > listaBrojeva3[j])
				{
					temp = listaBrojeva3[j - 1];
					listaBrojeva3[j - 1] = listaBrojeva3[j];
					listaBrojeva3[j] = temp;

				}
			}
		}



		Console.WriteLine("\n");


		for (int i = 0; i < listaBrojeva3.Count; i++)
		{
			Console.WriteLine("Treci niz brojeva je:" + listaBrojeva3[i]);
		}
	}
}