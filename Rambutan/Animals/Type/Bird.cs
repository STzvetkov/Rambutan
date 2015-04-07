namespace Zoo.Animals.Type
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Employees;

    public abstract class Bird : Animal
    {
        public Bird(
           long animalID, AnimalType type, Gender gender,
           int age, FoodType foodType,
           decimal price,
           Cage cage, HabitatType habitat,
           HealthStatus healthStatus, Veterinarian examinedBy)
            : base (animalID, type, gender, age, foodType, price, cage, habitat, healthStatus, examinedBy)
        {           
          
        }

        public bool isBird() {
            return true;
        }
        
        // TODO : Provide fields and methods that describe bird's behaviour and states.
    }
}
