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

        public bool EatMeat(FoodStock food)
        {
            if (food.FoodFish >= 1)
            {
                food.FoodFish--;
                CurrentAmountOfFood++;
                Console.WriteLine("An pinguin is eating fish");
                return true;
            }
            else
            {
                return false;
            }
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
