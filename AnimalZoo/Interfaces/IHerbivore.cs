using System;
using AnimalZoo.Business;
               
namespace AnimalZoo.Interfaces
{
    public interface IHerbivore
    {
        bool EatPlants(FoodStock food);
    }
}
