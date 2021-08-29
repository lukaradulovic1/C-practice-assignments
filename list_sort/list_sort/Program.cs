using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace list_sort
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Unesite broj elemenata u listu: ");
			int n = int.Parse(Console.ReadLine());
			List<int> listaBrojeva =  new List<int>{};

			
			
			Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
				listaBrojeva.Add(rnd.Next(0, 20));
            }

			int temp = 0;
			for (int i = 0; i < listaBrojeva.Count - 1; i++)
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
            for (int i = 0; i < listaBrojeva.Count; i++)
            {
				Console.WriteLine(listaBrojeva[i]);
            }

		}

    }
}
