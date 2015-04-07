namespace Zoo.Animals.Species.Aquatic
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;


    public class ClownFish : Aquatic, IOmnivore, IFeedable
    {
        private FoodType typeOfFood;

        //public ClownFish(){
        
        //}
        public ClownFish(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.ClownFish, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Aquarium,
             healthStatus,  examinedBy)
        {

            this.TypeOfFood = FoodType.Mix;
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public FoodType TypeOfFood
        {
            get
            {
                return this.typeOfFood;
            }
            set
            {
                this.typeOfFood = value;
            }
        }

        public void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
        // food: algae, plankton, crustaceans
    }

    //Dolphine - Methods - for add
       
}
