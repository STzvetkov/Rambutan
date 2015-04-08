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
        { }
        public Aquatic(
           long animalID, AnimalSpeciesType type, Gender gender,
           int age, FoodType foodType,
           decimal price,
           Cage cage, HabitatType habitat,
           HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, type, gender, age, foodType, price, cage, habitat, healthStatus, examinedBy)
        {

        }
    }
}
