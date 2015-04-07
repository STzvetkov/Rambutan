namespace Zoo.Animals.Species.Bird
{
    using System;
    using Zoo.Animals.Consumables;
    using Zoo.Animals.Type;
    using Zoo.Common;
    using Zoo.Interfaces;

    public class Hoodie : Flying, IFeedable, IAnimal
    {
        //kva e tazi ptica .... ? :D
        // TODO : Implement needed methods and fields.
        // food: seed, fruit, insects, lizards

        public Hoodie(long animalID, Gender gender, int age, decimal price, Cage cage, HabitatType habitat, HealthStatus healthStatus, Employees.Veterinarian examinedBy) :
            base(animalID, AnimalSpeciesType.Eagle, gender, age, FoodType.Mix, price, cage, habitat, healthStatus, examinedBy)
        {
        }

        public void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
    }
}