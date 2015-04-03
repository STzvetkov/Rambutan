using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.Consumables
{
    class FeedingAnimalAndOrderingFood
    {
       public static void CreateFood()
        {
            var firstUnit = new FoodForMammals(100);
            firstUnit.CriticalLimitReached += FoodForMammals_CriticalLimitReached;
            firstUnit.FoodStorageLimitReached += FoodForMammals_FoodStorageLimitReached;

            Console.WriteLine("All food for Mammals: {0}", firstUnit);

            firstUnit.Feed(10);
            Console.WriteLine("Food Left: {0}", firstUnit);

            Console.WriteLine("press 'a' key to feed animals");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("Feeding mammals");
                firstUnit.Feed(6); // allAnimals.Select(an=>an.Mammal.Count) accordint to the number of all animals at the moment
                Console.WriteLine("Food Left: {0}", firstUnit);
            }
            Console.WriteLine("press 'b' key to order food");
            while (Console.ReadKey(true).KeyChar == 'b')
            {
                Console.WriteLine("Ordering food for mammals");
                firstUnit.Order(10); // order allways 10  //TODO: substract in the budget
                Console.WriteLine("Food Left: {0}", firstUnit);
            }
        }

        static void FoodForMammals_FoodStorageLimitReached(object sender, EventArgs e)
        {
            Console.WriteLine("Stop ordering more foods. Soon Storage limit will be reached");
        }

        static void FoodForMammals_CriticalLimitReached(object sender, EventArgs e)
        {
            Console.WriteLine("If you dont order food right now. The mammals will die from hunger");
        }
    }
}
