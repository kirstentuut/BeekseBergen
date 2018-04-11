using System;
using AnimalZoo.Interfaces;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Business;

namespace AnimalZoo.Fishes
{
    public class Shark : Fish, ICarnivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("...!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Shark");
        }


        public void EatMeat(FoodStock food)
        {
            food.FoodFish--;
            CurrentAmountOfFood++;
        }

        public Shark(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 0;
            this.MaxFood = 40;
            this.MinFood = 1;
            this.CurrentAmountOfFood = 1;
        }

    }
}
