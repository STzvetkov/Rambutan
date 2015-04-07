namespace Zoo.Animals.Type
{
    using System;
    

    public abstract class Aquatic : Animal
    {
        // TODO : Provide fields and methods that describe fish's behaviour and states.
        protected static HabitatType[] AvailableCageTypes = { HabitatType.Pool, HabitatType.Aquarium };
        
         //public Aquatic() { }
         public Aquatic(long animalID, AnimalType animalType, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, HabitatType habitat, string healthStatus, Employees.Veterinarian examinedBy)
             : base(animalID, animalType, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  habitat,
             healthStatus,  examinedBy)
        {
            // TODO: Complete member initialization
          
        }
    }
}
