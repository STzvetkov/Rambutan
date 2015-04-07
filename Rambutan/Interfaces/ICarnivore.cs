namespace Zoo.Interfaces
{
    using System;
    using Zoo.Animals.Consumables;

    public interface ICarnivore
    {
     FoodType TypeOfFood { get; set; }
    }
}
