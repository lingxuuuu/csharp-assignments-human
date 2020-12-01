using System;
using System.Collections.Generic;

namespace human
{
    public class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;

        // add a public "getter" property to access health
        public int Health
        {
            get
            {
                return health;
            }
        }

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string Name)
        {
            this.Name = Name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
            this.Dexterity = dexterity;
            this.health = health;
        }

        // Build Attack method
        public int Attack(Human target)
        {
            Human temp = target as Human;
            temp.health -= 5 * Strength;
            Console.WriteLine($"name: {this.Name}, health: {temp.health}");
            return temp.Health;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var NewHuman = new Human("Lee", 10, 50, 5, 20);
            Console.WriteLine($"This is first guy {NewHuman.Name}");
            Console.WriteLine(NewHuman.Strength);
            Console.WriteLine(NewHuman.Intelligence);
            Console.WriteLine(NewHuman.Dexterity);
            Console.WriteLine(NewHuman.Health);
            NewHuman.Attack(NewHuman);
        }
    }
}
