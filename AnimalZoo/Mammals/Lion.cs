using System;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Interfaces;
using AnimalZoo.Business;
               
namespace AnimalZoo.Mammals
{
    public class Lion : Mammal, ICarnivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Roar. Roar. Roar!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal Type: Lion");
        }

        public bool EatMeat(FoodStock food)
        {
            if (food.FoodBeef >= 1)
            {
                food.FoodBeef--;
                CurrentAmountOfFood++;
                Console.WriteLine("An lion is eating beef");
                return true;
            }
            else
            {
                return false;
            }
        }

        public Lion(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
            this.MaxFood = 30;
            this.MinFood = 1;
            this.CurrentAmountOfFood = 1;

        }
    }
}
