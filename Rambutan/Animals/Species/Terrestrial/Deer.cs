namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;

    public class Deer : Terrestrial, IHerbivore, IFeedable
    {
         private Food deer_food;


        public Deer(){
        
        }
        public Deer(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Fox, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Steppe,
             healthStatus,  examinedBy)
        {
          
            this.Deer_food = new Food(quanty_of_food);
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public Food Deer_food
        {
            get
            {
                return this.deer_food;
            }
            set
            {
                this.deer_food = value;
            }
        }
        //Dolphine - Methods - for add
       
    }
}