using System;
using AnimalZoo.Interfaces;

namespace AnimalZoo.Fishes
{
    public class Shark : AnimalGroups.Fish, ICarnivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("...!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Shark");
        }

        public void EatMeat()
        {
            
        }

        public Shark(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 0;
        }

    }
}
