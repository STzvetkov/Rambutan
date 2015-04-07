namespace Zoo.Animals.Species.Bird
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;

    public class Penguin : Flightless, ICarnivore, IFeedable
    {
        private bool fly;
        private bool bird;
        private FoodType typeOfFood;
      

        // TODO : Implement all fields and methods needed.
        // food: small fish, crustaceans
       

        public Penguin(){
        
        }
        public Penguin(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, HabitatType habitat, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID,AnimalType.Penguin, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  habitat,
             healthStatus,  examinedBy)
        {
            this.fly = isFlyable();
            this.bird = isBird();
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
            Console.WriteLine("Am Am");
        }
        //Dolphine - Methods - for add
       
    }
}
