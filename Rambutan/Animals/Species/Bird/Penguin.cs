namespace Zoo.Animals.Species.Bird
{
    using System;

    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    public class Penguin : Flightless, IFeedable, IAnimal
    {
        private bool fly;
        private bool bird;

        // TODO : Implement all fields and methods needed.
        // food: small fish, crustaceans


        //public Penguin(){

        //}
        public Penguin(long animalID, Gender gender, int age, decimal price, long cageID, HabitatType habitat, HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, AnimalSpeciesType.Penguin, gender, age, FoodType.Meat, price, cageID, habitat, healthStatus, examinedBy)
        {
            this.fly = isFlyable();
            this.bird = isBird();
        }

        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public override void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
        //Dolphine - Methods - for add

    }
}
