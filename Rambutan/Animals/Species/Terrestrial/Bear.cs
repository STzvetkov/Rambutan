namespace Zoo.Animals.Species.Terrestrial
{
    using System;

    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    public class Bear : Terrestrial, IFeedable, IAnimal
    {
        public int QuantityOfFoodNeededToFeed { get; private set; }
        // Add information about lions, implement Carnivore's and Animal's methods and fields.
        // food: seed, fruit, insects, fish and other animals

        public Bear(Object[] dataInit)
            : base(dataInit)
        {
        }

        public Bear(int quantityOfFoodNeededToFeed, long animalID, Gender gender, int age, decimal price, long cageID, HealthStatus healthStatus)
            : base(animalID, AnimalSpeciesType.Lion, gender, age, FoodType.Mix, price, cageID, HabitatType.Steppe, healthStatus)
        {
            this.QuantityOfFoodNeededToFeed = quantityOfFoodNeededToFeed;
        }


        // TODO : Implement needed methods and fields.
        // food: fish, other animals        
        //Dolphine - Methods - for add


        public override void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
    }
}