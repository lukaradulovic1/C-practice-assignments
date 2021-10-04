using System;

namespace Animals_Robots
{
    public class Program
    {
        static void Main()
        {
            // animals
            var Rex = new Dog();
            var Kitty = new Cat();
            // robots
            var RoombaChaChaCha = new Roomba();
            var DustOTron = new MurderRobot();
            
            Rex.Bark();
            Rex.Poop();
            Kitty.Meow();
            Kitty.Poop();

            RoombaChaChaCha.Clean();
            RoombaChaChaCha.Drive();
            DustOTron.Drive();
            DustOTron.Kill();

        }
    }
}
