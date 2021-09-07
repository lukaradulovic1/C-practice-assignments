﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Characters.Warriors
{
    public class Warrior
    {
        

        private static int idCounter;


        public static int id;
        private int height;
        private int weight;
        private int age;
        private string name;
        private Sword swordWeapon;



        public Warrior()
        : this(180, 95)
        {

        }

        public Warrior(int height, int weight)
        : this(height, weight, "Young Warrior")
        {

        }
        public Warrior(int height, int weight, string name)

        {
            this.Height = height;
            Weight = weight;
            Age = 18;
            Name = name;
            this.swordWeapon = new Sword();
        }

        public Warrior(int height, int weight, string name, int age, Sword weapon)
        {
            
            
            this.Height = height;
            this.Weight = weight;
            this.Name = name;
            this.Age = age;
            this.Weapon = weapon;
            id++;



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
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 18 && value <= 45)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"The selected age for {name} is not a proper age for a warrior.\nAge must be between 18 and 45.");

                }
            }
        }

        public Sword Weapon
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

        public void Greetings(Warrior warrior)
        {
            Console.WriteLine($"Greetings {warrior.Name}!");
        }



    }
}