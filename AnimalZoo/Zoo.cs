using System;
using System.Collections.Generic;
using AnimalZoo.AnimalGroups;
using AnimalZoo.Birds;
using AnimalZoo.Fishes;
using AnimalZoo.Mammals;
using AnimalZoo.Reptiles;


namespace AnimalZoo
{
    public class Zoo
    {
        List<Animal> _animallist;
        public Zoo()
        {
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

        public void Eats()
        {
            
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
