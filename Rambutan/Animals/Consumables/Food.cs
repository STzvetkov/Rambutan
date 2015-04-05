namespace Zoo.Animals.Consumables
{
    using System;

    public struct Food
    {
        // TODO : Enter needed fields and methods. No properties!
        int quantity;
        
        public Food(int inputQuantity)
        {
            this.quantity = inputQuantity;
           
        }

        public void ConsumeAmount(int amount)
        {
            
            this.quantity -= amount;
           
        }

        public void ReplenishAmount(int amount)
        {

            this.quantity += amount;

        }

        public  int GetQuantity ()
        {

            return this.quantity;
        }
    }
}
