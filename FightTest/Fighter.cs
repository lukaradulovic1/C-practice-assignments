using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Fighter
    {
        private int healthPoints;
        private int damagePoints;
        private string name;

        public int HealthPoints { get => healthPoints; set => healthPoints = value; }
        public int DamagePoints { get => damagePoints; set => damagePoints = value; }
        public string Name { get => name; set => name = value; }

        public Fighter(int healthPoints, int damagePoints, string name)
        {
            this.HealthPoints = healthPoints;
            this.DamagePoints = damagePoints;
            this.Name = name;
        }

        public void IsAttacking(Fighter fighter)
        {
        fighter.HealthPoints = fighter.HealthPoints - fighter.DamagePoints;
            Console.WriteLine($"{fighter.Name} now has {HealthPoints}");

        }



    }

