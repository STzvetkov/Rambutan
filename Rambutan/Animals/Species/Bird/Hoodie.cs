namespace Zoo.Animals.Species.Bird
{
    using System;
    using Zoo.Animals.Consumables;
    using Zoo.Animals.Type;
    using Zoo.Interfaces;

    public class Hoodie : Flying, IOmnivore, IFeedable
    {
        //kva e tazi ptica .... ? :D
        // TODO : Implement needed methods and fields.
        // food: seed, fruit, insects, lizards
        private FoodType typeOfFood;

        public Hoodie(long animalID, Employees.Gender gender, int age, string dietType,
            decimal price, DateTime arrivalDate, Cage cage, HabitatType habitat,
            string healthStatus, Employees.Veterinarian examinedBy) : 
            base(animalID, AnimalType.Eagle, gender,age, dietType,
            price, arrivalDate, cage, habitat,
            healthStatus, examinedBy)
        {
            this.TypeOfFood = FoodType.Mix;
        }

        public FoodType TypeOfFood
        {
            get
            {
                return this.typeOfFood;
            }
            set
            {
                this.typeOfFood = value;
            }
        }

        public void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }
    }
}