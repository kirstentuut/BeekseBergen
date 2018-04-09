using System;
namespace AnimalZoo.AnimalGroups
{
    public abstract class Reptile : Animal
    {
        public override void AnimalGroup()
        {
            Console.WriteLine("Animal group: Reptile");
        }

        public Reptile()
        {
        }
    }
}
