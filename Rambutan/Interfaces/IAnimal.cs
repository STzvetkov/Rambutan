namespace Zoo.Interfaces
{
    using Zoo.Animals;
    using Zoo.Animals.Consumables;
    using Zoo.Common;

    interface IAnimal
    {
        AnimalSpeciesType Type { get; }
        Gender Gender { get; }
        int Age { get; }
        FoodType FoodType { get; }
    }
}
