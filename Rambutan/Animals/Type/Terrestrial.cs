namespace Zoo.Animals.Type
{
    using System;
    

    public abstract class Terrestrial : Animal
    {
        //public Terrestrial() { }
        public Terrestrial(long animalID, AnimalType animalType, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, HabitatType habitat, string healthStatus, Employees.Veterinarian examinedBy)
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
