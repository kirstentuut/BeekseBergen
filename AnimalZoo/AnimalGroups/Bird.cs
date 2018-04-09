using System;
namespace AnimalZoo.AnimalGroups
{
    public abstract class Bird : Animal
    {
        public override void AnimalGroup()
        {
            Console.WriteLine("Animal group: Mammal");
        }

        public Bird()
        {
        }
    }
}
