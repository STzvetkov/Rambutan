namespace Zoo.Employees
{
    using System;

    public enum Gender
    {
        Male,
        Female
    }


    public class Employee
    {
        private string firstName;
        private string lastName;
        private Gender gender;
        private DateTime dateOfBirth;

        private int staffID;
        private string position;
        //private string username;
        //private string password;

        private string street;
        private string city;
        private string contact;
        private int postalNumber;

        public Employee()
        {
        }

        public Employee(string firstName, string lastName, string position)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // TODO : Implement more constructors.

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

        public int StaffID
        {
            get { return this.staffID; }
            set { this.staffID = value; }   // TODO : Enter checks.
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }  // TODO : Enter checks
        }

        // TODO : Enter eventually username and password properties.

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
    }
}
