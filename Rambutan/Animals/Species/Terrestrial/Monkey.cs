namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;


    public class Monkey : Terrestrial, IHerbivore, IFeedable
    {
        private FoodType banans;


        //public Monkey(){
        
        //}
        public Monkey(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Monkey, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Steppe,
             healthStatus,  examinedBy)
        {

            this.Banans = FoodType.Plant;
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public FoodType Banans
        {
            get
            {
                return this.banans;
            }
            set
            {
                this.banans = value;
            }
        }

        //Dolphine - Methods - for add
       
    }
}
