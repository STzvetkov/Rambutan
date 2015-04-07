namespace Zoo.Animals.Species.Aquatic
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;

    public class Dolphin : Aquatic, ICarnivore, IFeedable
    {


        private FoodType fish;
     


        public Dolphin(){
        
        }
        public Dolphin(int quanty_of_food, long animalID, Employees.Gender gender, int age, string dietType, decimal price, DateTime arrivalDate, Cage cage, string healthStatus, Employees.Veterinarian examinedBy)
              : base(animalID, AnimalType.Dolphin, gender,
           age,  dietType, 
             price,  
             arrivalDate,  cage,  HabitatType.Pool,
             healthStatus,  examinedBy)
        {


            this.Fish = FoodType.Meat;
        }

        
        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public FoodType Fish
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
        //public void replenishFoodPersonal(int replenishQuantity)
        //{
        //    this.fish.ReplenishAmount(replenishQuantity);
        //}

        //public void consumeFoodPersonal(int bla, string somefood)
        //{
        //    switch (somefood)
        //    {
        //        case "fish":
        //            this.fish.ConsumeAmount(bla);
        //            break;
        //        default:
        //            this.fish.ConsumeAmount(bla);
        //            break;
        //    }

        //}

        //public int supplysFoodPersoanl()
        //{
        //    return this.fish.GetQuantity();
        //}
        // food: small fish, cuttlefish

    }
}