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

            _animallist = new List<Animal>();
             _animallist.Add(new Rabbit("Thumper", 3, "Female", 5));
            _animallist.Add(new Elephant("Ollie", 75, "male", 1250));
            _animallist.Add(new Lion("Nala", 20,"Female", 90));
            _animallist.Add(new Bear("Knut", 40, "male", 110));
            _animallist.Add(new Pinguin("Pingu", 12, "Female", 35));
            _animallist.Add(new Shark("Lenny", 19, "Male", 135));
            _animallist.Add(new Crocodile("Croc", 32, "Female", 95));
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
            //Random rnd = new Random();

            //int numberfromlist = rnd.Next(0, _animallist.Count);

            //Animal randomanimal = numberfromlist Animal._animallist;

            //Animal randomanimal = new Random();

            //Console.WriteLine($"{randomanimal}");

            //switch (randomanimal)
            //{
            //    //case Animal.Elephant
            //}

            foreach (Animal animalA in _animallist)
            {
                while (!animalA.IsFull)
                {
                    bool haseaten = false;

                    if (animalA is ICarnivore carnivore)
                    {
                        haseaten = carnivore.EatMeat(_foodstock);
                    }
                    if (animalA is IHerbivore herbivore)
                    {
                        haseaten = herbivore.EatPlants(_foodstock);
                    }
                    if (haseaten == false)
                    {
                        Console.WriteLine($"{animalA.Name} is still hungry");
                        break;
                        //_foodstock.Reset();
                    }
                }

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
