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
            // TODO : Needs a while cycle to offer add certain amount of food to certain storage.
        }

        public static void FeedAnimals()
        {
            var meatFood = new Food(FoodType.Meat, 101, 10);        // first order of meet
            var plantFood = new Food(FoodType.Plant, 10001, 1000);  // first order of plants

            meatFood.CriticalLimitReached += meatFood_CriticalLimitReached;

            bool isUsingTheFeedAnimalsMenu = true;
            while (isUsingTheFeedAnimalsMenu)
            {
                Console.Clear();             
                Print(2, 12, "Feeding carnivores.");
                Print(2, 12, string.Format("Meat left: {0}", meatFood));
                Print(6, 10, " 1. Feed carnivorous animals");

                ConsoleKeyInfo userInput = Console.ReadKey();

                TakeChoice(userInput);
               

                //Console.WriteLine("Feeding mammals"); 
                //Console.WriteLine("Food Left: {0}", meatFood);

                if (userInput.Key == ConsoleKey.D0)
                {
                    isUsingTheFeedAnimalsMenu = false;
                }
            }

        }

        private static void TakeChoice(ConsoleKeyInfo userInput)
        {
            switch (userInput.Key)
            {
                case ConsoleKey.D1:      // TODO : Add a single instance of meet usable by all classes. Use it here to deplete it.
                    //meatFood.Deplete(6); // allAnimals.Select(an=>an.Mammal.Count) accordint to the number of all animals at the moment
                    break;

            }
        }

        static void meatFood_CriticalLimitReached(object sender, EventArgs e)
        {
            Print(30,12,"If you dont order Meat right now. The Carnivorous will die from hunger");
        }

        private static void Print(int row, int col, object data)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(data);
        }
    }
}
