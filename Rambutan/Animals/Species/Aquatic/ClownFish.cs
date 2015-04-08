namespace Zoo.Animals.Species.Aquatic
{
    using System;

    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;


    public class ClownFish : Aquatic, IFeedable, IAnimal
    {
        public ClownFish(){

        }
        public ClownFish(Object[] dataInit)
            : base(dataInit)
        {
        }

        public ClownFish(int quanty_of_food, long animalID, Gender gender, int age, decimal price, long cageID, HealthStatus healthStatus)
            : base(animalID, AnimalSpeciesType.ClownFish, gender, age, FoodType.Mix, price, cageID, HabitatType.Aquarium, healthStatus)
        {
        }


        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public override void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
        // food: algae, plankton, crustaceans
    }

    //Dolphine - Methods - for add

}
