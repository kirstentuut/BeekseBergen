using System;
namespace AnimalZoo
{
    public class Elephant : Mammals
    {

		public override void AnimalSound()
		{
            Console.WriteLine("Pawoo. Pawoo. Pawoo!");
		}


        public Elephant(string name, int age, string gender, int weight)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Weight = weight;
            this.NumberOflegs = 4;
            this.Eat = "Leaves";
        }
    }
}
