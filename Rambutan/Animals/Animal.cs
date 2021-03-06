﻿namespace Zoo.Animals
{
    using System;
    using Zoo.Animals.Consumables;
    using Zoo.Common;
    using Zoo.Employees;
    using Zoo.Interfaces;

    public abstract class Animal : IAnimal,IFeedable
    {
        private long animalID;
        private AnimalSpeciesType type; // AnimalType enumeration
        private Gender gender;   // Gender enumeration
        private int age;
        private FoodType foodType;  // FoodType enumeration
        private decimal price;
        private long cageID;
        private HabitatType habitat;    // HabitatType enumeration   
        private HealthStatus healthStatus;  // HealthStatus enumeration
        private Veterinarian examinedBy;

        // constructors

        public Animal()
        { }
        public Animal(long animalID)
        {
            this.AnimalID = animalID;
        }

        public Animal(Object[] dataInit)
        {
            this.AnimalID = long.Parse(dataInit[0].ToString());
            this.Type = GetAnimalType(dataInit[1].ToString());
            this.Gender = GetGender(dataInit[2].ToString());
            this.Age = int.Parse(dataInit[3].ToString());
            this.FoodType = GetFoodType(dataInit[4].ToString());
            this.Price = decimal.Parse(dataInit[5].ToString());     
        }

        public Animal(
            long animalID, AnimalSpeciesType type, Gender gender,
            int age, FoodType foodType,
            decimal price,
            long cageID, HabitatType habitat,
            HealthStatus healthStatus)
            : this(animalID)
        {
            this.Type = type;
            this.Gender = gender;
            this.Age = age;
            this.FoodType = foodType;
            this.Price = price;
            this.CageID = cageID;
            this.Habitat = habitat;
            this.HealthStatus = healthStatus;
        }

        // methods 
        public virtual void Eat(int quantity)
        {
        }

        private AnimalSpeciesType GetAnimalType(string inputStrType)
        {
            try
            {
                return (AnimalSpeciesType)Enum.Parse(typeof(AnimalSpeciesType), inputStrType, true);
            }
            catch (Exception)
            {
                throw new ArgumentException("AnimalSpeciesType", "Invalid AnimalSpeciesType!");
            }
        }

        private Gender GetGender(string inputStrType)
        {
            try
            {
                return (Gender)Enum.Parse(typeof(Gender), inputStrType, true);
            }
            catch (Exception)
            {
                throw new ArgumentException("Gender", "Invalid Gender!");
            }
        }

        private FoodType GetFoodType(string inputStrType)
        {
            try
            {
                return (FoodType)Enum.Parse(typeof(FoodType), inputStrType, true);
            }
            catch (Exception)
            {
                throw new ArgumentException("FoodType", "Invalid FoodType!");
            }
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

        public AnimalSpeciesType Type
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

        public long CageID
        {
            get
            {
                return this.cageID;
            }
            set
            {
                this.cageID = value;
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
            this.CageID,
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