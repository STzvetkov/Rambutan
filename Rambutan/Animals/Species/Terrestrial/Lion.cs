namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;


    public class Lion : Terrestrial, ICarnivore, IFeedable
    {
        private FoodType typeOfFood;


        public Lion(){
        
        }
        public Lion(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Lion, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Steppe,
             healthStatus,  examinedBy)
        {

            this.TypeOfFood = FoodType.Meat;
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
            Console.WriteLine("Am Aa");
        }
        //Dolphine - Methods - for add
       
    }
}
