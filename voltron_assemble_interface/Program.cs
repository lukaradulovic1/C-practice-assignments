using System;

namespace voltron_assemble_interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            var voltron = new Voltron();
            voltron.Assemble(100);

            Console.WriteLine(voltron.CurrentHealth);
            Console.WriteLine(voltron.Move());
            voltron.Special();
            voltron.TakeDamage(50);
            Console.WriteLine($"Voltron attack value is {voltron.Attack()}");
        }
    }
}
