namespace Zoo.Animals.Type
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Common;
    using Zoo.Employees;

    public abstract class Flightless : Bird
    {
        public Flightless(
         long animalID, AnimalSpeciesType type, Gender gender,
         int age, FoodType foodType,
         decimal price,
         Cage cage, HabitatType habitat,
         HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, type, gender, age, foodType, price, cage, habitat, healthStatus, examinedBy)
        {

        }

        public bool isFlyable()
        {
            return false;
        }
    }
}
