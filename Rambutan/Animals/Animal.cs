namespace Zoo.Animals
{
    using System;

    using Zoo.Animals.Consumables;
    using Zoo.Employees;
    using Zoo.Interfaces;

    public enum HealthStatus
    {
        Healthy,
        Sick
    }

    public abstract class Animal : IFeedable
    {
        private long animalID;
        private AnimalType type; // AnimalType enumeration
        private Gender gender;   // Gender enumeration
        private int age;
        private FoodType foodType;  // FoodType enumeration
        private decimal price;
        private Cage cage;
        private HabitatType habitat;    // HabitatType enumeration   
        private HealthStatus healthStatus;  // HealthStatus enumeration
        private Veterinarian examinedBy;

        // constructors

        public Animal(long animalID)
        {
            this.AnimalID = animalID;
        }

        public Animal(
            long animalID, AnimalType type, Gender gender,
            int age, FoodType foodType,
            decimal price,
            Cage cage, HabitatType habitat,
            HealthStatus healthStatus, Veterinarian examinedBy)
            : this(animalID)
        {
            this.Type = type;
            this.Gender = gender;
            this.Age = age;
            this.FoodType = foodType;
            this.Price = price;
            this.Cage = cage;
            this.Habitat = habitat;
            this.HealthStatus = healthStatus;
            this.ExaminedBy = examinedBy;
        }

        // properties 

        public long AnimalID
        {
            get
            {
                return this.animalID;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("AnimalID cannot be zero!");
                }

                this.animalID = value;
            }
        }

        public AnimalType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public FoodType FoodType
        {
            get
            {
                return this.foodType;
            }
            set
            {
                this.foodType = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Animal price cannot be zero!");
                }
                this.price = value;
            }
        }

        public Cage Cage
        {
            get
            {
                return this.cage;
            }
            set
            {
                this.cage = value;
            }
        }

        public HabitatType Habitat
        {
            get
            {
                return this.habitat;
            }
            set
            {
                this.habitat = value;
            }
        }

        public HealthStatus HealthStatus
        {
            get
            {
                return this.healthStatus;
            }
            set
            {
                this.healthStatus = value;
            }
        }

        public Veterinarian ExaminedBy
        {
            get
            {
                return this.examinedBy;
            }
            set
            {
                this.examinedBy = value;
            }
        }

        // methods 
        public void Eat(int quantity)
        {
            Console.WriteLine("Am Am");
        }

        public override string ToString()
        {
            return string.Format(
            @"AnimalID : {0} 
AnimalType: {1}
Gender: {2}
Age: {3}
FoodType: {4}
Price: {5}
Cage: {6}
Habitat: {7}
HealthStatus: {8}
ExaminedBy: {9}",
            this.AnimalID,
            this.Type,
            this.Gender,
            this.Age,
            this.FoodType,
            this.Price,
            this.Cage,
            this.Habitat,
            this.HealthStatus,
            this.ExaminedBy,
            new string('-', 40)
            );
        }

        //public void changeCage(Cage cageNum)
        //{
        //    // cage`s doesn`t work ?!
        //    this.Cage.RemoveAnimal(this);
        //    cageNum.AddAnimal(this);
        //}
        //
        //public void changeHealthStatus(HealthStatus status)
        //{            
        //    if (status == "Sick")
        //    {
        //        this.HealthStatus = status;
        //        //make vet appoyntment
        //    }
        //    else
        //    {
        //        this.HealthStatus = status;
        //    }
        //}
        //
        //public void changePriceTag(decimal price)
        //{
        //    //good ,bad
        //    this.Price = price;
        //}

    }
}