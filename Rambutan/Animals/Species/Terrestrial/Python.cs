namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    public class Python : Terrestrial, IFeedable, IAnimal
    {
        public Python(Object[] dataInit)
            : base(dataInit)
        {
            this.QuantityOfFoodNeededToFeed = int.Parse(dataInit[11].ToString());
        }

        public Python(int quantityOfFoodNeededToFeed, long animalID, Gender gender, int age, decimal price, long cageID, HealthStatus healthStatus)
            : base(animalID, AnimalSpeciesType.Python, gender, age, FoodType.Meat, price, cageID, HabitatType.Steppe, healthStatus)
        {
            this.QuantityOfFoodNeededToFeed = quantityOfFoodNeededToFeed;
        }

        public int QuantityOfFoodNeededToFeed { get; private set; }

        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public override void Eat(int quantity)
        {
            Console.WriteLine("Am Aa");
        }

        //Dolphine - Methods - for add


    }
}
