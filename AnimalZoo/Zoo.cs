using System;
using System.Collections.Generic;

namespace AnimalZoo
{
    public class Zoo
    {
        List<Animal> _animallist;
        public Zoo()
        {
            _animallist = new List<Animal>();
            _animallist.Add(new Animal());
        }

        public void ListenToSounds ()
        {
            foreach (Animal A in _animallist)
            {
                A.AnimalSound();
            }
        }
    }


    public class Animal
    {
        public int NumberOflegs { get; set; }
        public string SkinType { get; set; }
        public string ColorSkin { get; set; }
        public virtual void AnimalSound()
        {
            Console.WriteLine("Moeee");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Zoo Blijdorp = new Zoo();
            Blijdorp.ListenToSounds();
        }
    }
}
