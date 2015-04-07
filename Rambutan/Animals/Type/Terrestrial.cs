namespace Zoo.Animals.Type
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Employees;

    public abstract class Terrestrial : Animal
    {
        public Terrestrial(
           long animalID, AnimalType type, Gender gender,
           int age, FoodType foodType,
           decimal price,
           Cage cage, HabitatType habitat,
           HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, type, gender, age, foodType, price, cage, habitat, healthStatus, examinedBy)
        {

        }
    }
}
