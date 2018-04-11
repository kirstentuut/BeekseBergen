using System;
using AnimalZoo.Interfaces;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Business;

namespace AnimalZoo.Mammals
{
    public class Bear : Mammal, ICarnivore, IHerbivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Growl. Growl. Growl!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Bear");
        }

        public void EatMeat(FoodStock food)
        {
            if (food.FoodFish >=1)
            {
                food.FoodFish--;
                CurrentAmountOfFood++;
            }

        }

        public void EatPlants(FoodStock foodstock)
        {
            foodstock.FoodLeaves--;
            CurrentAmountOfFood++;
        }

        public Bear(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
            this.MaxNumberOfChildernInWomb = 10;
            this.MaxFood = 50;
            this.MinFood = 1;
            this.CurrentAmountOfFood = 1;
        }
    }
}
