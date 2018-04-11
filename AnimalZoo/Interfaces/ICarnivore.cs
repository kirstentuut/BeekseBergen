using System;
using AnimalZoo.Business;

namespace AnimalZoo.Interfaces
{
    public interface ICarnivore
    {
        void EatMeat(FoodStock food);
    }
}
