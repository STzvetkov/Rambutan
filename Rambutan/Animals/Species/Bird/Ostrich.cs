namespace Zoo.Animals.Species.Bird
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;

    public class Ostrich : Flightless, IOmnivore, IFeedable
    {
       
        // food: plants, insects, lizards
         private bool fly;
        private bool bird;
        //shte se preraboti hranata sled kato se zavurshat vsichkite
        private Food fish;

       
        public Ostrich(){
        
        }
        public Ostrich(int quanty_of_food, long animalID,Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, HabitatType habitat, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Ostrich, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  habitat,
             healthStatus,  examinedBy)
        {
            this.fly = isFlyable();
            this.bird = isBird();

            this.Fish = new Food(quanty_of_food);
        }
      
       
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
