using System;
using AnimalZoo.Interfaces;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Business;

namespace AnimalZoo.Birds
{
    public class Pinguin : Bird, ICarnivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Peep. Peep. Peep!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Pinguin");
        }

        public void EatMeat(FoodStock food)
        {
            food.FoodFish--;
            CurrentAmountOfFood++;
        }

        public Pinguin(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 2;
            this.MaxFood = 15;
            this.MinFood = 1;
            this.CurrentAmountOfFood = 1;
        }
    }
}
