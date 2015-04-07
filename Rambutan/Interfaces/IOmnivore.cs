namespace Zoo.Interfaces
{
    using System;
    using Zoo.Animals.Consumables;

    public interface IOmnivore
    {
        FoodType TypeOfFood { get; set; }
    }
}
