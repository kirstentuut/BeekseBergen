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


        public bool EatMeat(FoodStock food)
        {
            if (food.FoodFish >= 1)
            {
                food.FoodFish--;
                CurrentAmountOfFood++;
                Console.WriteLine("An shark is eating fish");
                return true;
            }
            else
            {
                return false;
            }
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
