using System;
using AnimalZoo.Interfaces;

namespace AnimalZoo.Mammals
{
    public class Bear : AnimalGroups.Mammal, ICarnivore, IHerbivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Growl. Growl. Growl!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Bear");
        }

        public void EatMeat()
        {
            
        }

        public void EatPlants()
        {
            
        }

        public Bear(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
        }
    }
}
