﻿namespace Zoo.Animals.Species.Terrestrial
{
    using System;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;
    using Zoo.Employees;
    using Zoo.Animals.Consumables;
    using Zoo.Common;


    public class Lion : Terrestrial, ICarnivore, IFeedable
    {
        public int QuantityOfFoodNeededToFeed { get; private set; }
        //public Lion(){

        //}
        public Lion(int quantityOfFoodNeededToFeed,long animalID, Gender gender, int age, decimal price, Cage cage, HealthStatus healthStatus, Veterinarian examinedBy)
            : base(animalID, AnimalSpeciesType.Lion, gender, age, FoodType.Meat, price, cage, HabitatType.Steppe, healthStatus, examinedBy)
        {
            this.QuantityOfFoodNeededToFeed = quantityOfFoodNeededToFeed;
        }

        // TODO : Implement needed methods and fields.
        // food: fish, other animals

        public void Eat(int quantity)
        {
            Console.WriteLine("Am Aa");
        }
        //Dolphine - Methods - for add

    }
}
