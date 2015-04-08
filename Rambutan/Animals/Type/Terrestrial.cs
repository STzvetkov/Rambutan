namespace Zoo.Animals.Type
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Common;
    using Zoo.Employees;
    using Zoo.Interfaces;

    public abstract class Terrestrial : Animal, IAnimal
    {
        public Terrestrial(
           long animalID, AnimalSpeciesType type, Gender gender,
           int age, FoodType foodType,
           decimal price,
           long cageID, HabitatType habitat,
           HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, type, gender, age, foodType, price, cageID, habitat, healthStatus, examinedBy)
        {

        }
    }
}
