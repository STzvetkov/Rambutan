namespace Zoo.Animals.Species.Aquatic
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;


    public class ClownFish : Aquatic, IOmnivore, IFeedable
    {
        private FoodType plancton;

        //public ClownFish(){
        
        //}
        public ClownFish(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.ClownFish, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Aquarium,
             healthStatus,  examinedBy)
        {

            this.Plancton = FoodType.Plant;
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public FoodType Plancton
        {
            get
            {
                return this.plancton;
            }
            set
            {
                this.plancton = value;
            }

        }
        
        // food: algae, plankton, crustaceans
    }

    //Dolphine - Methods - for add
       
}
