namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;


    public class Fox : Terrestrial, ICarnivore, IFeedable
    {
         private Food meat;


        public Fox(){
        
        }
        public Fox(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Fox, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Steppe,
             healthStatus,  examinedBy)
        {
          
            this.Meat = new Food(quanty_of_food);
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public Food Meat
        {
            get
            {
                return this.meat;
            }
            set
            {
                this.meat = value;
            }
        }
    
    }
}