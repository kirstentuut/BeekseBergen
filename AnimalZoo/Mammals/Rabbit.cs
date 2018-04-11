using System;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Interfaces;
using AnimalZoo.Business;

namespace AnimalZoo.Mammals
{
    public class Rabbit : Mammal, IHerbivore
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Roar. Roar. Roar!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal Type: Lion");
        }

        public void EatPlants(FoodStock food)
        {
            food.FoodGrass--;
            CurrentAmountOfFood++;
        }

        public Rabbit(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
            this.MaxFood = 5;
            this.MinFood = 1;
            this.CurrentAmountOfFood = 1;

        }
    }
}
