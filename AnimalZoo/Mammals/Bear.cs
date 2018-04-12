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

        public bool EatMeat(FoodStock food)
        {
            if (food.FoodFish >=1)
            {
                food.FoodFish--;
                CurrentAmountOfFood++;
                Console.WriteLine("An bear is eating fish");
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EatPlants(FoodStock food)
        {
            if (food.FoodLeaves >= 1)
            {
                food.FoodLeaves--;
                CurrentAmountOfFood++;
                return true;
            }
            else
            {
                return false;
            }
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
