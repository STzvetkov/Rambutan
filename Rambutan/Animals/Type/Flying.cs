using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.Type
{
    public abstract class Flying:Bird
    {
      
       public Flying() { }
       public Flying(long animalID, AnimalType animalType, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, HabitatType habitat, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, animalType, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  habitat,
             healthStatus,  examinedBy)
        {
            // TODO: Complete member initialization
           
        }
       public bool isFlyable() {
           return true;
       }
    }
}
