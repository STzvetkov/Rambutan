namespace Zoo.Animals.Species.Terrestrial
{
    using System;

    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    public class Deer : Terrestrial, IFeedable, IAnimal
    {
        public int QuantityOfFoodNeededToFeed { get; private set; }

        public Deer(Object[] dataInit)
            : base(dataInit)
        {
        }

        public Deer(int quantityOfFoodNeededToFeed, long animalID, Gender gender, int age, decimal price, long cageID, HealthStatus healthStatus)
            : base(animalID, AnimalSpeciesType.Fox, gender, age, FoodType.Plant, price, cageID, HabitatType.Steppe, healthStatus)
        {
            this.QuantityOfFoodNeededToFeed = quantityOfFoodNeededToFeed;
        }


        // TODO : Implement needed methods and fields.
        // food: fish, other animals


        public override void Eat(int quantity)
        {
            Console.WriteLine("Am Aa");
        }
        //Dolphine - Methods - for add

    }
}