namespace Zoo.Animals.Species.Terrestrial
{
   using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    public class Rabbit : Terrestrial, IHerbivore, IFeedable
    {
         private Food carrots;


        public Rabbit(){
        
        }
        public Rabbit(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Rabbit, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Steppe,
             healthStatus,  examinedBy)
        {
          
            this.Carrots = new Food(quanty_of_food);
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public Food Carrots
        {
            get
            {
                return this.carrots;
            }
            set
            {
                this.carrots = value;
            }

        }

        //Dolphine - Methods - for add
       
        
    }
}