namespace Zoo.Animals.Consumables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Zoo.Menu;

    public class FoodManipulations
    {        
        public static void OrderFood()
        {
            var meatStorage = new FoodStorage(FoodStorageType.Freezer);
            var plantStorage = new FoodStorage(FoodStorageType.Normal);

            //bool isUsingTheFeedAnimalsMenu = true;
            //while (isUsingTheFeedAnimalsMenu)
            //{
            //    Console.Clear();

            //    Print(2, 12, string.Format("Meat left: {0} ", meatStorage));
            //    Print(6, 10, " 1. Order meat");
            //    Print(7, 10, " 2. Order plants");
            //    Print(8, 10, " 0. Back");
            //    ConsoleKeyInfo userInput = Console.ReadKey();


            //    TakeChoice(userInput);

            //    if (userInput.Key == ConsoleKey.D0)
            //    {
            //        isUsingTheFeedAnimalsMenu = false;
            //    }
            //}


            // TODO : Needs a while cycle to offer add certain amount of food to certain storage.
        }

        public static void FeedAnimals()
        {

            var meatFood = new Food(FoodType.Meat, 101, 10);        // orders a bunch of meat - this shuuld be in the storage class
            var plantFood = new Food(FoodType.Plant, 10001, 1000);  // first order of plants


            meatFood.CriticalLimitReached += meatFood_CriticalLimitReached;

            bool isUsingTheFeedAnimalsMenu = true;
            while (isUsingTheFeedAnimalsMenu)
            {
                Console.Clear();
               
                int shift = (Console.WindowWidth - 20) / 2;
                Console.ForegroundColor = ConsoleColor.DarkYellow;                
                
                Print(12, shift, " 1. Feed herbivore animals");
                Print(15, shift, " 2. Feed carnivorous animals");
                Print(18, shift, " 0. Back");

                Print(21, 12, string.Format("{0}", meatFood));

                while (Console.ReadKey(true).KeyChar == '2')
                {
                    Print(23, 12, "Feeding Carnivorous");
                    Print(25, 12, String.Format("Food Left: {0}", meatFood));
                    //Console.WriteLine("Feeding mammals");                
                    meatFood.Deplete(6); // allAnimals.Select(an=>an.Mammal.Count) accordint to the number of all animals at the moment
                    //Console.WriteLine("Food Left: {0}", meatFood);
                }

                ConsoleKeyInfo userInput = Console.ReadKey();
                
                TakeChoice(userInput);

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
                    Console.WriteLine("BAU BAU");
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
