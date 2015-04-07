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

        // Constructor
        public FoodStorage(FoodStorageType type)
        {
            this.typeOfStorage = type;

        }

        // Methods
        public void Order(Food f)
        {
            storage.Add(f);
        }

    }
}
