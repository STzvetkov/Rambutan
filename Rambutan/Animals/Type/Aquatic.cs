namespace Zoo.Animals.Type
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Common;
    using Zoo.Employees;
    using Zoo.Interfaces;

    public abstract class Aquatic : Animal, IAnimal
    {
        // TODO : Provide fields and methods that describe fish's behaviour and states.
        protected static HabitatType[] AvailableCageTypes = { HabitatType.Pool, HabitatType.Aquarium };

        public Aquatic()
        {
        }

        public Aquatic(Object[] dataInit)
            : base(dataInit)
        {
        }
        public Aquatic(long animalID, AnimalSpeciesType type, Gender gender, int age, FoodType foodType,
                       decimal price, long cageID, HabitatType habitat, HealthStatus healthStatus)
            : base(animalID, type, gender, age, foodType, price, cageID, habitat, healthStatus)
        {
        }
    }
}
