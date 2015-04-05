namespace Zoo.Animals.Species.Bird
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;

    public class Eagle : Flying, ICarnivore, IFeedable
    {
        private bool fly;
        private bool bird;
       
        private Food fish;


        public Eagle(){
        
        }
        public Eagle(int quanty_of_food, long animalID,Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, HabitatType habitat, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Eagle, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  habitat,
             healthStatus,  examinedBy)
        {
            this.fly = isFlyable();
            this.bird = isBird();
            this.Fish = new Food(quanty_of_food);
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public Food Fish
        {
            get
            {
                return this.fish;
            }
            set
            {
                this.fish = value;
            }

        }

        //Dolphine - Methods - for add
       
    }
}