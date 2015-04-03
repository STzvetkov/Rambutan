namespace Zoo.Animals
{
    using System;
    using Zoo.Employees;
    using Zoo.Interfaces;

    public enum AnimalType
    {
        ClownFish,
        Dolphin,
        Eagle,
        Hoodie,
        Ostrich,
        Penguin,
        Bear,
        Deer,
        Fox,
        Lion,
        Monkey,
        Python,
        Rabbit
    }

    public abstract class Animal : IFeedable
    {
        // abstract information/methods that all animals can have.

        private long animalID;

        private AnimalType type; // AnimalType enumeration

        private Gender gender;   // Gender enumeration

        private int age;

        private string dietType;

        private decimal price;

        //private double height;

        //private double weight;

        //private string color;

        //private string description;       

        private DateTime arrivalDate;

        private Cage cage;              // TODO: add number of cage (Animal don't need all information about the cage => ToString()) 

        private HabitatType habitat;    // TODO: HabitatType enumeration      

        private string healthStatus;

        //private DateTime dateOfLastExamination;

        private Veterinarian examinedBy;    // TODO: add name of veterinarian (Animal don't need all information about him => ToString()) 

        // constructors

        public Animal()
        {

        }

        public Animal(long animalID)
        {
            this.AnimalID = animalID;
        }

        public Animal(long animalID, AnimalType type, Gender gender,
            int age, string dietType, 
            decimal price,  
            DateTime arrivalDate, Cage cage, HabitatType habitat,
            string healthStatus, Veterinarian examinedBy)
            : this(animalID)
        {
            this.Type = type;
            this.Gender = gender;
            this.Age = age;
            this.DietType = dietType;
            this.Price = price;
            this.ArrivalDate = arrivalDate;
            this.Cage = cage;
            this.Habitat = habitat;
            this.HealthStatus = healthStatus;
            this.ExaminedBy = examinedBy;
        }

        // TODO : Implement more constructors, if it's necessary.

        //properties => TODO : Enter checks.

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
                    throw new ArgumentException("AnimalID can not be null!");
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
                // TODO: Enter checks
                this.age = value;
            }
        }

        public string DietType
        {
            get
            {
                return this.dietType;
            }
            set
            {
                // TODO: Enter checks
                this.dietType = value;
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
                // TODO: Enter checks
                this.price = value;
            }
        }

        public DateTime ArrivalDate
        {
            get
            {
                return this.arrivalDate;
            }
            set
            {
                // TODO: Enter checks
                this.arrivalDate = value;
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
                // TODO: Enter checks
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

        public string HealthStatus
        {
            get
            {
                return this.healthStatus;
            }
            set
            {
                // TODO: Enter checks
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
                // TODO: Enter checks
                this.examinedBy = value;
            }
        }

        // TODO: eventually implement more properties after corroboration of the fields

        // methods 

        // TODO: modify ToString() after corroboration of the fields
        //        public override string ToString()
        //        {
        //            return string.Format(

        //           @"AnimalID : {0} 
        //AnimalType: {1}
        //Gender: {2}
        //DietType: {3}
        //Height: {4} 
        //Weight: {5}
        //Color: {6}
        //Description: {7}
        //ArrivalDate: {8}
        //Cage: {9}
        //Habitat: {10}
        //HealthStatus: {11}
        //DateOfLastExamination: {12}
        //ExaminedBy: {13}
        //{14}",
        //            this.animalID,
        //                //this.type,
        //            this.gender,
        //            this.dietType,
        //                //this.height,
        //                //this.weight,
        //                //this.color,
        //                //this.description,        
        //            this.arrivalDate,
        //            this.cage,
        //                //this.habitat,
        //            this.healthStatus,
        //            this.dateOfLastExamination,
        //            this.examinedBy,
        //            new string('-', 40)
        //           );
        //        }

        //TODO: Implement more methods
    }
}
