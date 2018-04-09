using System;
namespace AnimalZoo
{
    public class Bear : Mammals
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Growl. Growl. Growl!\n");
        }

        public override void AnimalType()
        {
            Console.WriteLine("Animal type: Bear");
        }

        public Bear(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
            this.Eat = "Fish";
        }
    }
}
