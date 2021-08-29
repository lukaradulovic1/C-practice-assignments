using System;


    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "jedan", "dva" };
            string[] arr2 = { "tri", "cetiri" };



            string[] arr3 = new string[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i] + " " + arr2[i];
            }


            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

        }
    }

