using System;

namespace DITest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the persons name, age and adress");
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var adress = new Adress(Console.ReadLine());
           

            var person = new Person (name, age, adress);
            Console.WriteLine(person.ToString());
        }
    }



}
