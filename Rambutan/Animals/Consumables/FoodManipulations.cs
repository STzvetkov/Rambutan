namespace Zoo.Animals.Consumables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoodManipulations
    {
        public static void CreateStorage()
        {
            var meatStorage = new FoodStorage(FoodStorageType.Freezer);
            var plantStorage = new FoodStorage(FoodStorageType.Normal);

        }

        public static void OrderFood()
        {
            var meatFood = new Food(FoodType.Meat, 101, 10);
            var plantFood = new Food(FoodType.Plant, 10001, 1000);

            Console.WriteLine("Ordering food for mammals");
            meatFood.Deplete(10); // order allways 10  //TODO: substract in the budget
            Console.WriteLine("Food Left: {0}", meatFood);


            meatFood.CriticalLimitReached += meatFood_CriticalLimitReached;

            Console.WriteLine("All food for Mammals: {0}", meatFood);

            Console.WriteLine("press 'a' key to feed animals");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("Feeding mammals");
                meatFood.Deplete(6); // allAnimals.Select(an=>an.Mammal.Count) accordint to the number of all animals at the moment
                Console.WriteLine("Food Left: {0}", meatFood);
            }

        }

        static void meatFood_CriticalLimitReached(object sender, EventArgs e)
        {
            Console.WriteLine("If you dont order Meat right now. The Carnivorous will die from hunger");
        }
    }
}
