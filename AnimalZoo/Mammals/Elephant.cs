using System;
using AnimalZoo.Interfaces;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Business;

namespace AnimalZoo.Mammals
{
    public class Elephant : Mammal, IHerbivore
    {
		public override void AnimalSound()
		{
            Console.WriteLine("Pawoo. Pawoo. Pawoo!\n");
		}

		public override void AnimalType()
		{
            Console.WriteLine("Animal type: Elephant");
		}

        public void EatPlants(FoodStock food)
        {
            food.FoodLeaves--;
            CurrentAmountOfFood++;
        }

        public Elephant (string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
            this.MaxFood = 90;
            this.MinFood = 1;
            this.CurrentAmountOfFood = 1;
        }

    }
}
