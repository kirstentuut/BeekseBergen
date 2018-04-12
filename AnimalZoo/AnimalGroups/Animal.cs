using System;
namespace AnimalZoo.AnimalGroups
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
        public int Weight { get; set; }
        public string Name { get; set; }

        //Food stuff:
        public int MaxFood { get; set; }
        public int MinFood { get; set; }
        public int CurrentAmountOfFood { get; set; }

        public bool IsFull => CurrentAmountOfFood >= MaxFood;

        public bool IsStarving => CurrentAmountOfFood < MinFood;

        //public static implicit operator Animal(Random v)
        //{
        //    throw new NotImplementedException();
        //}




        //public abstract void Eat();

        //private int _gender;
        //public int Gender {
        //    get {return _gender;}
        //    set { _gender = value; }
        //}

    }
}
