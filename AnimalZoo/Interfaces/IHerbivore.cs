using System;
using AnimalZoo.Business;
               
namespace AnimalZoo.Interfaces
{
    public interface IHerbivore
    {
        void EatPlants(FoodStock food);
    }
}
