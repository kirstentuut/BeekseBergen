using System;
using AnimalZoo.Interfaces;

namespace AnimalZoo.Mammals
{
    public class Elephant : AnimalGroups.Mammal, IHerbivore
    {
		public override void AnimalSound()
		{
            Console.WriteLine("Pawoo. Pawoo. Pawoo!\n");
		}

		public override void AnimalType()
		{
            Console.WriteLine("Animal type: Elephant");
		}

		public void EatPlants()
        {
            
        }

        public Elephant(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
        }
    }
}
