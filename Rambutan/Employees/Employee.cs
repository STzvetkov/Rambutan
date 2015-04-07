namespace Zoo.Employees
{
    using System;

    using Zoo.Common;
    using Zoo.Interfaces;

    public abstract class Employee : IEmployee
    {
        private string firstName;
        private string lastName;
        private Gender gender;
        private DateTime dateOfBirth;

        private string street;
        private string city;
        private string contact;
        private int postalNumber;

        private int staffID;
        private Position position;

        public Employee(string firstName, string lastName, Position position)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
        }

        public Employee(Position position)
        {
            this.Position = position;
        }

        // TODO : Implement more constructors.


        public override string ToString()
        {
            return string.Format(

@"Name : {0} {1}
Gender: {2}
Date of birth: {3}

Adress: {4}, {5}
Contact: {6}
Postal number: {7}

Staff ID: {8}
Position: {9}
",
 this.firstName, this.lastName,
 this.gender,
 this.dateOfBirth,
 this.street, city,
 this.contact,
 this.postalNumber,
 this.staffID,
 this.position
);
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; } // TODO : Enter checks.
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; } // TODO : Enter checks.
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }   // TODO : Enter checks.
        }

        public string Street
        {
            get { return this.street; }
            set { this.street = value; }    // TODO : Enter checks.
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }  // TODO : Enter checks.
        }

        public string Contact
        {
            get { return this.contact; }
            set { this.contact = value; }   // TODO : Enter checks.
        }

        public int PostalNumber
        {
            get { return this.postalNumber; }
            set { this.postalNumber = value; }  // TODO : Enter checks.
        }

        public int StaffID
        {
            get { return this.staffID; }
            set { this.staffID = value; }   // TODO : Enter checks.
        }

        public Position Position
        {
            get { return this.position; }
            set { this.position = value; }  // TODO : Enter checks
        }

        // TODO : Enter eventually username and password properties.
    }
}
