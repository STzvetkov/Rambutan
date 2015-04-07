namespace Zoo.Animals.Species.Bird
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    public class Ostrich : Flightless, IOmnivore, IFeedable
    {

        // food: plants, insects, lizards
        private bool fly;
        private bool bird;
        //shte se preraboti hranata sled kato se zavurshat vsichkite

        //public Ostrich(){

        //}
        public Ostrich(long animalID, Gender gender, int age, decimal price, Cage cage, HabitatType habitat, HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, AnimalSpeciesType.Ostrich, gender, age, FoodType.Mix, price, cage, habitat, healthStatus, examinedBy)
        {
            this.fly = isFlyable();
            this.bird = isBird();
        }

        // food: fish, other animals

        public void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }

        //Dolphine - Methods - for add

    }
}
