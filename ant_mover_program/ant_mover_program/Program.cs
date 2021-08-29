using System;
using System.Collections.Generic;
using System.Text;
using ant_mover_program.Ant_body_parts.AntThorax;
namespace ant_mover_program
{
    public class Program
    {

        static void Main()
        {
            //body parts
            var antHead = new AntHead();
            var antAbdomen = new AntAbdomen();
            var antThorax = new AntThorax();
            
            Console.WriteLine("Skittering noises in the background.\n\n");
            Console.WriteLine("\n\nI am ANT-ONIO, move me.\n\n");
            Console.WriteLine("Anthill in the distance...\n\n");

            Ant ant = new(antHead, antAbdomen, antThorax);
            antThorax.AddLegToThorax();


            bool antWalking = true;

            while (antWalking == true)
            {

                Console.WriteLine("\nPress Enter to move the ant.");
                Console.WriteLine("Press Escape to exit.\n\n");

                
                Console.ReadKey();

                ant.Walk();
                ant.ToString();

            }
            
        }


    }
}



