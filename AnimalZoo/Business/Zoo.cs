using System;
using System.Collections.Generic;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Interfaces;
using AnimalZoo.Birds;
using AnimalZoo.Fishes;
using AnimalZoo.Mammals;
using AnimalZoo.Reptiles;


namespace AnimalZoo.Business
{
    public class Zoo
    {
        public FoodStock _foodstock;

        List<Animal> _animallist;

        public Zoo()
        {
            _foodstock = new FoodStock();

            //Elephant Ollie = new Elephant()
            //{
            //    Age = 125, 
            //    Gender = "Male",
            //    Weight = 1200
            //};

            _animallist = new List<Animal>();
            _animallist.Add(new Elephant("Ollie", 75, "male", 1250));
            _animallist.Add(new Lion("Nala", 20,"Female", 90));
            _animallist.Add(new Bear("Knut", 40, "male", 110));
            _animallist.Add(new Pinguin("Pingu", 12, "Female", 35));
            _animallist.Add(new Shark("Lenny", 19, "Male", 135));
            _animallist.Add(new Crocodile("Croc", 32, "Female", 95));
            _animallist.Add(new Rabbit("Thumper", 3, "Female", 5));

        }

        public void ShowAllInfo ()
        {
            foreach (Animal animalA in _animallist)
            {
                animalA.AnimalGroup();
                animalA.AnimalType();

                Console.WriteLine($"Name: {animalA.Name} \n"
                                  + $"Age: {animalA.Age} \n"
                                  + $"Gender: {animalA.Gender}\n"
                                  + $"Weight: {animalA.Weight} kg");

                animalA.AnimalSound();
            }
        }   

        public void Feeding()
        {
            
            foreach (Animal animalA in _animallist)
            {
                while (!animalA.IsFull)
                {
                    if (animalA is ICarnivore carnivore)
                    {
                        
                        //ICarnivore carnivore = (ICarnivore)animalA;
                        carnivore.EatMeat(_foodstock);
                    }
                    if (animalA is IHerbivore herbivore)
                    {
                        herbivore.EatPlants(_foodstock);
                    }
                }
                //Console.WriteLine($"{_foodstock.FoodBeef}\n {_foodstock.FoodGrass}");
            }
        }


        public void AliveAnimals()
        {
            foreach (Animal animalA in _animallist)
            {
                animalA.AnimalGroup();
                animalA.AnimalType();
                Console.WriteLine($"Name: {animalA.Name}");
            }
        }
    }
}
