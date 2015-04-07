namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;

    public class Python : Terrestrial, ICarnivore, IFeedable
    {
         private FoodType mice;


        public Python(){
        
        }
        public Python(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Python, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Steppe,
             healthStatus,  examinedBy)
        {

            this.Mice = FoodType.Meat;
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public FoodType Mice
        {
            get
            {
                return this.mice;
            }
            set
            {
                this.mice = value;
            }
        }

        //Dolphine - Methods - for add
       

    }
}
