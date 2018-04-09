using System;
namespace AnimalZoo
{
    public abstract class Animal
    {

        //Determinded for all animal groups
        public virtual bool ChildrenInWomb()
        {
            return false;
        }

        public int NumberOflegs { get; set; }

        public abstract void AnimalGroup();


        //Determinded for every animal type
        public abstract void AnimalSound();
        public abstract void AnimalType();

        //Determinded for every individual animal
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Eat { get; set; }
        public int Weight { get; set; }
        public string Name { get; set; }

        //private int _gender;
        //public int Gender {
        //    get {return _gender;}
        //    set { _gender = value; }
        //}

    }
}
