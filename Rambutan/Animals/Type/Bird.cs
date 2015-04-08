namespace Zoo.Animals.Type
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Common;
    using Zoo.Employees;
    using Zoo.Interfaces;

    public abstract class Bird : Animal, IAnimal
    {
        public Bird(Object[] dataInit)
            : base(dataInit)
        {
        }

        public Bird(long animalID, AnimalSpeciesType type, Gender gender, int age, FoodType foodType, 
                    decimal price, long cageID, HabitatType habitat, HealthStatus healthStatus)
            : base(animalID, type, gender, age, foodType, price, cageID, habitat, healthStatus)
        {

        }

        public bool isBird()
        {
            return true;
        }

        // TODO : Provide fields and methods that describe bird's behaviour and states.
    }
}
