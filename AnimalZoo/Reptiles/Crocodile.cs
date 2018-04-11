using System;
using AnimalZoo.Interfaces;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Business;

namespace AnimalZoo.Reptiles
{
    public class Crocodile : AnimalGroups.Reptile, ICarnivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Raw. Raw. Raw!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Crocolide");
        }

        public void EatMeat(FoodStock food)
        {
            food.FoodBeef--;
            CurrentAmountOfFood++;
        }

        public Crocodile(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
        }
    }
}
