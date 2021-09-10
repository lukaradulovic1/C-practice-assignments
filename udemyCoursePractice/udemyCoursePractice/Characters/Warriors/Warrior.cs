using Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior : Character
    {
        //static field
        private static int idCounter;
        //constants
        private const int DEFAULT_HEIGHT = 180;
        private const int DEFAULT_WEIGHT = 95;
        private const int DEFAULT_AGE = 18;
        private const string DEFAULT_NAME = "Young Warrior";
        private readonly Sword DEFAULT_SWORD_WEAPON = new Sword();

        // fields
        private readonly int id;
        private int height;

        
        private Sword swordWeapon;
        private Faction faction;


        // constructors
        public Warrior()
        : this(DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {

        }

        public Warrior(int height, int weight)
        : this(height, weight, DEFAULT_NAME, Faction.Default)
        {

        }
        public Warrior(int height, int weight, string name)

        {
            IdCounter++;
            this.id = IdCounter;
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;


        }

        public Warrior(int height, int weight, string name, Faction faction)
        {

            IdCounter++;
            this.id = IdCounter;
            this.Height = height;
            base.Weight = weight;
            this.Name = name;
            this.Faction = faction;
            base.Age = DEFAULT_AGE;
            this.SwordWeapon = DEFAULT_SWORD_WEAPON;

            if (this.faction == Faction.GoodGuy)
            {
                base.HealhtPoints = 120;
            }
            else if (this.faction == Faction.BadGuy)
            {
                base.HealhtPoints = 100;
            }

        }

        public Warrior(int healthPoints, int weight, int age)
        : base(healthPoints, weight, age)
        {
            
        }

        // properties
        public int Id
        {
            get
            {
                return this.id;
            }

        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }



        public Sword SwordWeapon
        {
            get
            {
                return swordWeapon;
            }
            set
            {
                swordWeapon = value;
            }
        }
        public static int IdCounter
        {
            get
            {
                return Warrior.idCounter;
            }
            private set
            {
                Warrior.idCounter = value;
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            private set
            {
                this.faction = value;
            }
        }



        //methods
        public void SpecialWarriorGreeting()
        {
            base.Greetings(base.Name);
        }

        public static void GetDefaultValues(Warrior warrior)
        {
            Console.WriteLine(
                $"Default height is {DEFAULT_HEIGHT}\n" +
                $"Default weight is {DEFAULT_WEIGHT}\n" +
                $"Default age is {DEFAULT_AGE}\n" +
                $"Default name is {DEFAULT_NAME} \n" +
                $"Default weapon damage {warrior.DEFAULT_SWORD_WEAPON.Damage}");
        }

        public override void Move(int pauseBetweenMovements)
        {
            base.Move(pauseBetweenMovements);
            Console.WriteLine("I just moved 10 times, I am a Warrior.");
        }

    }
}
