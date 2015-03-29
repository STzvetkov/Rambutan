namespace Zoo.Animals
{
    using System;

    public enum CageType { Pool, Aquarium, Steppe}

    //TODO: enumeration with habitat type (coop, pool, etc.)
    public class Cage // They are not exactly consumables but will be bought or repaired frequently.
    {
        // TODO : Enter needed fields and methods.
        private double width;
        private double height;
        private double depth;
        private decimal price;
        private bool isRepaired;
        //TODO: add fieal with habitat type

        public Cage(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
            this.Price = (decimal)(width * depth);
            this.IsRepaired = true;
        }

        public bool IsRepaired
        {
            get
            {
                return this.isRepaired;
            }
            set
            {
                this.isRepaired = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The length cannot be negative!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The length cannot be negative!");
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The length cannot be negative!");
                }

                this.depth = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }

        public void Break()
        {
            // TODO : if something happens : 
            this.IsRepaired = false;
        }

        public void Repair()
        {
            this.IsRepaired = true;
        }

        // TODO : Depending on the dimensions of the cage : what animal will be in 
    }
}
