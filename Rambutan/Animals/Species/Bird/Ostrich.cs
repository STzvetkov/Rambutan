namespace Zoo.Animals.Species.Bird
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    public class Ostrich : Flightless, IFeedable, IAnimal
    {

        // food: plants, insects, lizards
        private bool fly;
        private bool bird;
        //shte se preraboti hranata sled kato se zavurshat vsichkite

        public Ostrich(Object[] dataInit)
            : base(dataInit)
        {
        }

        public Ostrich(long animalID, Gender gender, int age, decimal price, long cageID, HabitatType habitat, HealthStatus healthStatus)
            : base(animalID, AnimalSpeciesType.Ostrich, gender, age, FoodType.Mix, price, cageID, habitat, healthStatus)
        {
            this.fly = isFlyable();
            this.bird = isBird();
        }

        // food: fish, other animals

        public override void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }

        //Dolphine - Methods - for add

    }
}
