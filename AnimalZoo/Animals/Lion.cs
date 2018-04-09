using System;
namespace AnimalZoo
{
    public class Lion : Mammals
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Roar. Roar. Roar!");
        }

        public Lion(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
            this.Eat = "Beef";
        }
    }
}
