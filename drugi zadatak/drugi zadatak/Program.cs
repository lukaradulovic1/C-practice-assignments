using System;
//    for(f=1;f*f<=e;f++) 
//{
  //  if ((f * f) == e)
  //      printf("%d", f);
//}

class Program
{
    static void Main(string[] args)
    {

        int n = 75625;

        for (int i = 1; i * i <= n; i++)
        {
            if ((i * i) == n)
            {
                Console.WriteLine(i);
            }

        }
    }
}

