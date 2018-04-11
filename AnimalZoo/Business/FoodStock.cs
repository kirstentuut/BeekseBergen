using System;
namespace AnimalZoo.Business
{
    public class FoodStock
    {
        public int FoodFish {get; set; }

        public int FoodLeaves { get; set; }

        public int FoodBeef { get; set; }

        public int FoodGrass { get; set; }

        private int foodFruit;

        public int FoodFruit
        {
            get
            {
                return foodFruit;
            }

            set
            {
                if (value >=0 )
                {
                    foodFruit = value;
                }
                else 
                {
                    throw new NoFoodExeption();
                }
            }
        }

        public void Reset ()
        {
            this.FoodBeef = 10;
            this.FoodFish = 10;
            this.FoodFruit = 10;
            this.FoodGrass = 10;
            this.FoodLeaves = 10;
        }

        public FoodStock()
        {
            Reset();
        }
    }
}
