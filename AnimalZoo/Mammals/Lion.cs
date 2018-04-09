using System;
using AnimalZoo.Interfaces;
               
namespace AnimalZoo.Mammals
{
    public class Lion : AnimalGroups.Mammal, ICarnivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Roar. Roar. Roar!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal Type: Lion");
        }

        public void EatMeat()
        {
            
        }

        public Lion(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
        }
    }
}
