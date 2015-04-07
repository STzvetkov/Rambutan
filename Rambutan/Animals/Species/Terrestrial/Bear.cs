namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    public class Bear : Terrestrial, IOmnivore, IFeedable, ICarnivore
    {
        // Add information about lions, implement Carnivore's and Animal's methods and fields.
        // food: seed, fruit, insects, fish and other animals
        private FoodType typeOfFood;


        public Bear(){
        
        }
        public Bear(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Lion, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Steppe,
             healthStatus,  examinedBy)
        {


            this.TypeOfFood = FoodType.Mix;
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals        
        //Dolphine - Methods - for add

      
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
    }
}