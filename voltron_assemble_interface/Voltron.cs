using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using voltron_assemble_interface.Weapons;

namespace voltron_assemble_interface
{
    public class Voltron : IVoltronPart
    {
        private List<IVoltronPart> voltronParts = new List<IVoltronPart>();
        private double currentHealth;
        private readonly List<IVoltronWeapon> voltronWeapons = new List<IVoltronWeapon>();


        public double CurrentHealth
        {
            get
            {
                return currentHealth;
            }
        }

        //add Voltron body parts to the list
        public void Assemble(int health)
        {
            Console.WriteLine("Voltron has 0% unity.");
            currentHealth = health;
            VoltronLeftArm voltronLeftArm = new();
            VoltronRightArm voltronRightArm = new();
            VoltronLeftLeg voltronLeftLeg = new();
            VoltronRightLeg voltronRightLeg = new();
            VoltronTorso voltronTorso = new();

            voltronParts.Add(voltronRightLeg);
            voltronParts.Add(voltronRightArm);
            voltronParts.Add(voltronLeftLeg);
            voltronParts.Add(voltronLeftArm);
            voltronParts.Add(voltronTorso);
            Console.WriteLine("Voltron assembled.");
        }


        public double Move()
        {
            double crossedDistance = 0;
            foreach (var voltronPart in voltronParts)
            {
                crossedDistance += voltronPart.Move();
            }
            return crossedDistance;
        }
        public double Attack()
        {
            double attackValues = 0;
            foreach (var voltronWeapon in voltronWeapons)
            {
                attackValues += voltronWeapon.Attack();
            }
            foreach (var voltronPart in voltronParts)
            {
                attackValues += voltronPart.Attack();
            }
            return attackValues;
        }
        public void TakeDamage(double damage)
        {
            if (damage <= currentHealth)
            {
                currentHealth -= damage;
            }
            else
            {
                Console.WriteLine("Invalid health value.");
            }

            if (currentHealth > 0)
            {
                Console.WriteLine($"Voltron suffered {damage} damage and has {currentHealth} health points left");
            }
            else
            {
                currentHealth = 0;
                Console.WriteLine("Voltron is destroyed due to shields failing.");
            }
        }
        public void Special()
        {
            Random rnd = new Random();
            var randomWeapon = rnd.Next(0, 3);

            switch (randomWeapon)
            {
                case 0:
                    var armCannon = new ArmCannon();
                    voltronWeapons.Add(armCannon);
                    break;
                case 1:
                    var blazingSword = new BlazingSword();
                    voltronWeapons.Add(blazingSword);
                    break;
                case 2:
                    var shoulderCannon = new ShoulderCannon();
                    voltronWeapons.Add(shoulderCannon);
                    break;
                case 3:
                    var twinShortSwords = new TwinShortSwords();
                    voltronWeapons.Add(twinShortSwords);
                    break;

                default:
                    Console.WriteLine("Wrong values input.");
                    break;
            }
            Console.WriteLine(voltronWeapons[0]);

        }

    }
}
