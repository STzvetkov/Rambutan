namespace Zoo.Schedules
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Zoo.Animals;
    using Zoo.Animals.Consumables;

    public class FeedingSchedule : Schedule
    {
        // TODO : Override ToString()

        // feeded once or twice a day

        private ICollection<Animal> animals;

        private ICollection<Food> food;


         public FeedingSchedule(string newName, string newTime)
            : base (newName, newTime)
        {
            this.animals = new List<Animal>();
            this.food = new List<Food>();

        }

         public FeedingSchedule(string newName, string newTime, string newRepeat)
            :base (newName, newTime, newRepeat)
        {
            this.animals = new List<Animal>();
            this.food = new List<Food>();
        }

        public void AddAnimal(Animal newAnimal)
        {
            this.animals.Add(newAnimal);
        }

        public void RemoveAnimal(Animal newAnimal)
        {
            this.animals.Remove(newAnimal);
        }

        public ICollection<Animal> AnimalsList
        {
            get
            {
                return this.animals;
            }
        }

        public void AddFood(Food newFood)
        {
            this.food.Add(newFood);
        }

        public ICollection<Food> FoodList
        {
            get
            {
                return this.food;
            }
        }

        public override string ToString()
        {
            StringBuilder schedule = new StringBuilder();
           
            schedule.AppendLine("Animals: ");
            foreach (var animal in animals)
            {
                //TODO Add Animal name
                schedule.AppendLine(string.Format("{0,7} - {2}", animal.Type, animal.AnimalID));
            }
           
            schedule.AppendLine("Food: ");
            foreach (var meal in food)
            {
                //TODO Add food name
                schedule.AppendLine(string.Format("{0,7}", meal.GetType().Name));
            }

            return base.ToString() + schedule.ToString();
        }
    }
}
