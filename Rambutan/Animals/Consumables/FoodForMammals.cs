using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.Consumables
{
    public struct FoodForMammals
    {
        public event EventHandler CriticalLimitReached; // the EventHandler
        public event EventHandler FoodStorageLimitReached; // the EventHandler

        void OnCriticalLimitReached(EventArgs e)
        {
            // proverka za zakacheni subscribers
            if (this.CriticalLimitReached != null)
            {
                this.CriticalLimitReached(this, e);
            }
        }

        void OnFoodStorageLimitReached(EventArgs e)
        {
            // proverka za zakacheni subscribers
            if (this.FoodStorageLimitReached != null)
            {
                this.FoodStorageLimitReached(this, e);
            }
        }

        private int foodAvailable;
        private int foodLimitBeforeOrder;
        private int foodStorageLimit;

        // Constructors
        public FoodForMammals(int initialFood, int foodLimitBeforeOrder, int foodStorageLimit) : this()
        {
            this.foodAvailable = initialFood;
            this.foodLimitBeforeOrder = 10;
            this.foodStorageLimit = 110;
        }

        //// Properties
        //public int FoodAvailable { get; set; }
        //public int FoodLimit { get; set; }

        // Methods
        public void Feed(int portion)
        {
            if (portion > foodAvailable)
            {
                Console.WriteLine(" Not enought food");                
            }            

            else
            {
                foodAvailable -= portion;     
            }

            if (foodAvailable <= foodLimitBeforeOrder)
            {
                OnCriticalLimitReached(EventArgs.Empty);
            }

        }

        public void Order(int amount)
        {
            if (foodStorageLimit-foodAvailable < amount)
            {
                Console.WriteLine("Not enough space in Storage");
            }

            else
            {
                foodAvailable += amount;
            }           

            if (foodAvailable >= foodStorageLimit)
            {
                OnFoodStorageLimitReached(EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", this.foodAvailable);
        }
    }
}
