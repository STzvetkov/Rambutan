using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animals.Consumables
{  
    public struct Food
    {
        public event EventHandler CriticalLimitReached; // the EventHandler        

        void OnCriticalLimitReached(EventArgs e)
        {
            // proverka za zakacheni subscribers
            if (this.CriticalLimitReached != null)
            {
                this.CriticalLimitReached(this, e);
            }
        }        

        private FoodType typeOfFood;
        
        private int foodAvailable;
        private int foodLimitBeforeOrder;        
        

        // Constructors
        public Food(FoodType type, int initialFood, int foodLimitBeforeOrder) : this()
        {
            this.typeOfFood = type;
            this.foodAvailable = initialFood;
            this.foodLimitBeforeOrder = 10;
        }      

        // Methods
        public override string ToString()
        {
            return String.Format("{0} of {1} available", this.foodAvailable, this.typeOfFood);
        }

        public void Deplete(int amount) // feeding animals shoud invoke also method Deplete()
        {
            if (amount > foodAvailable)
            {
                Console.WriteLine(" Not enought food");
            }

            else
            {
                foodAvailable -= amount;
            }

            if (foodAvailable <= foodLimitBeforeOrder)
            {
                OnCriticalLimitReached(EventArgs.Empty);
            }

        }       
    }
}
