using System;
namespace AnimalZoo
{
    public abstract class Mammals : Animal
    {
        public override bool ChildrenInWomb()
        {
            return true;
        }

		public override void AnimalGroup()
		{
            Console.WriteLine("Animal group: Mammal");
		}

		public Mammals()
        {
        }

    }
}
