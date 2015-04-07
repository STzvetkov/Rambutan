namespace Zoo.Animals.Species.Aquatic
{
    using System;

    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;


    public class ClownFish : Aquatic, IOmnivore, IFeedable
    {
        //public ClownFish(){

        //}
        public ClownFish(int quanty_of_food, long animalID, Gender gender, int age, decimal price, Cage cage, HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, AnimalSpeciesType.ClownFish, gender, age, FoodType.Mix, price, cage, HabitatType.Aquarium, healthStatus, examinedBy)
        {
        }


        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
        // food: algae, plankton, crustaceans
    }

    //Dolphine - Methods - for add

}
