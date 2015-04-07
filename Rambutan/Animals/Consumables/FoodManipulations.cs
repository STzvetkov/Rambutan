namespace Zoo.Animals.Consumables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoodManipulations
    {
        public static void OrderFood()
        {
            var meatStorage = new FoodStorage(FoodStorageType.Freezer);
            var plantStorage = new FoodStorage(FoodStorageType.Normal);

        }

        public static void FeedAnimals()
        {
            var meatFood = new Food(FoodType.Meat, 101, 10);        // first order of meet
            var plantFood = new Food(FoodType.Plant, 10001, 1000);  // first order of plants

            Console.WriteLine("Feeding Carnivorous");            
            Console.WriteLine("Meat left: {0}", meatFood);
            meatFood.CriticalLimitReached += meatFood_CriticalLimitReached;
            Print(6, 10, " 1. Feed carnivorous animals");           
            while (Console.ReadKey(true).KeyChar == '1')
            {
                Print(21, 12, "Feeding Carnivorous");
                Print(22, 12, String.Format("Food Left: {0}", meatFood));
                //Console.WriteLine("Feeding mammals");                
                meatFood.Deplete(6); // allAnimals.Select(an=>an.Mammal.Count) accordint to the number of all animals at the moment
                //Console.WriteLine("Food Left: {0}", meatFood);
            }

        }

        static void meatFood_CriticalLimitReached(object sender, EventArgs e)
        {
            Console.WriteLine("If you dont order Meat right now. The Carnivorous will die from hunger");
        }

        private static void Print(int row, int col, object data)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(data);
        }
    }
}
