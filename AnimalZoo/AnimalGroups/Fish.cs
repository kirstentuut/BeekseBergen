using System;
namespace AnimalZoo.AnimalGroups
{
    public abstract class Fish : Animal
    {
        public override void AnimalGroup()
        {
            Console.WriteLine("Animal group: Fish");
        }

        public Fish()
        {
        }
    }
}
