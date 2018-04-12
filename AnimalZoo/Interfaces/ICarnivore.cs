using System;
using AnimalZoo.Business;

namespace AnimalZoo.Interfaces
{
    public interface ICarnivore
    {
        bool EatMeat(FoodStock food);
    }
}
