using System;
using AnimalZoo.Business;
using AnimalZoo.Mammals;

namespace AnimalZoo
{
    public class BeekseBergen
    {
        static void Main(string[] args)
        {
            Business.Zoo BeekseBergen = new Business.Zoo();

            BeekseBergen.ShowAllInfo();

            BeekseBergen.Feeding();
        }

        public BeekseBergen()
        {
        }
    }
}
