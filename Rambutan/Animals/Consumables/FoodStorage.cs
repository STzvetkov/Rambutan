namespace Zoo.Animals.Consumables
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoodStorage
    {
        // Fields
        private FoodStorageType typeOfStorage;
        private List<Food> storage;
        private decimal price;
        private long storageID;

        // Constructor
        public FoodStorage(FoodStorageType type)
        {
            this.typeOfStorage = type;

        }

        // Properties

        public decimal Price 
        {
            get 
            {
                return this.price; 
            }
            set 
            {
                if (value <= 0 )
                {
                    throw new ArgumentException("Price shuld be positive");
                }
                this.price = value;
            } 
        
        }
        public FoodStorageType Type { get; set; }

        public long StorageID 
        {
            get 
            { 
                return this.storageID; 
            }
            set 
            {
                if (value <=0)
                {
                    throw new ArgumentException("ID must be positive");
                }
                this.storageID = value;
            } 
        }
        // Methods
        public void Order(Food f)
        {
            storage.Add(f);
        }

    }
}
