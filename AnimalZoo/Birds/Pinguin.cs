using System;
using AnimalZoo.Interfaces;

namespace AnimalZoo.Birds
{
    public class Pinguin : AnimalGroups.Bird, ICarnivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Peep. Peep. Peep!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Pinguin");
        }

        public void EatMeat()
        {
            
        }

        public Pinguin(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 2;
        }
    }
}
