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

        public bool EatMeat(FoodStock food)
        {
            if (food.FoodFish >= 1)
            {
                food.FoodBeef--;
                CurrentAmountOfFood++;
                Console.WriteLine("An crocodile is eating beef");
                return true;
            }
            else
            {
                return false;
            }
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
