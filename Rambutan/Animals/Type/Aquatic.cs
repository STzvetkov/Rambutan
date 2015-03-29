namespace Zoo.Animals.Type
{
    using System;
    

    public abstract class Aquatic : Animal
    {
        // TODO : Provide fields and methods that describe fish's behaviour and states.
        protected static CageType[] AvailableCageTypes = {CageType.Pool, CageType.Aquarium};
    }
}
