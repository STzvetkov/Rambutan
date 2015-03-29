namespace Zoo.Animals
{
    using System;

    public abstract class Animal
    {
        // abstract information/methods that all animals can have.

        private long animalID;

        private AnymalType type; // AnymalType is enumeration with all specific lowest level names like "Lion", "Python", etc.
        
        private Gender gender;  // Gender is enumeration

        private string dietType;

        private double height;

        private double weight;

        private string color;

        private string description;       
        
        private DateTime arrivalDate;

        private Cade cage;

        private HabitatType habitat;        

        private string healthStatus;

        private DateTime dateOfLastExamination

        private Veterinarian examinedBy;

        // constructors

        public Animal(string animalID)
        {
            this.AnimalID = animalID;
        }

        // TODO : Implement more constructors.

        //properties => TODO : Enter checks.

        public int animalID
        {
            get
            {
                return this.animalID;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("can not be null or empty!");
                }                
                this.animalID = value; 
            }
        }

        // TODO: implement more properties after corroboration of the fields

        // methods 

        public override string ToString()
        {
            return string.Format(

           @"AnimalID : {0} 
AnimalType: {1}
Gender: {2}
DietType: {3}
Height: {4} 
Weight: {5}
Color: {6}
Description: {7}
ArrivalDate: {8}
Cage: {9}
Habitat: {10}
HealthStatus: {11}
DateOfLastExamination: {12}
ExaminedBy: {13}
{14}",            
            this.animalID;
            this.type;
            this.gender;
            this.dietType;
            this.height;
            this.weight;
            this.color;
            this.description;        
            this.arrivalDate;
            this.cage;
            this.habitat;
            this.healthStatus;
            this.dateOfLastExamination
            this.examinedBy;            
            new string('-', 40)
           );
        }

        //TODO: Implement more methods
    }
}
