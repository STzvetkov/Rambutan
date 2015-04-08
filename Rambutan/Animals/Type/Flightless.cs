namespace Zoo.Animals.Type
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Common;
    using Zoo.Employees;
    using Zoo.Interfaces;

    public abstract class Flightless : Bird, IAnimal
    {
        public Flightless(Object[] dataInit)
            : base(dataInit)
        {
        }

        public Flightless(long animalID, AnimalSpeciesType type, Gender gender, int age, FoodType foodType,
                          decimal price, long cageID, HabitatType habitat, HealthStatus healthStatus)
            : base(animalID, type, gender, age, foodType, price, cageID, habitat, healthStatus)
        {

        }

        public bool isFlyable()
        {
            return false;
        }
    }
}
