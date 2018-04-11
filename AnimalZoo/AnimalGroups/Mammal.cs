using System;
namespace AnimalZoo.AnimalGroups
{
    public abstract class Mammal : Animal
    {
        public override bool ChildrenInWomb()
        {
            return true;
        }

        public int MaxNumberOfChildernInWomb { get; set; }

		public override void AnimalGroup()
		{
            Console.WriteLine("Animal group: Mammal");
		}

		public Mammal()
        {
        }

    }
}
