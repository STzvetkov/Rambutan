namespace Zoo.Schedules
{
    using System;
    using Zoo.Employees;
    using Zoo.Animals;
    using System.Collections.Generic;
    using System.Text;

    public class WorkingSchedule : Schedule
    {
        // TODO : Override ToString()

        // once a week veterinary exam at certain cage
        //private string workType { get; set; }

        private ICollection<Employee> employees;

        private ICollection<Animal> animals;

        private ICollection<Cage> cages;

        public string description { get; set; }

        //public WorkingSchedule():base
        //{
        //    this.employees = new List<Employee>();
        //}
        public WorkingSchedule(string newName, string newTime)
            : base (newName, newTime)
        {
            this.employees = new List<Employee>();
            this.animals = new List<Animal>();
            this.cages = new List<Cage>();

        }

        public WorkingSchedule(string newName, string newTime, string newRepeat)
            :base (newName, newTime, newRepeat)
        {
            this.employees = new List<Employee>();
            this.animals = new List<Animal>();
            this.cages = new List<Cage>();
        }


        public void AddEployee(Employee newEmployee)
        {
            this.employees.Add(newEmployee);
        }

        public void RemoveEmployee(Employee newEmployee)
        {
            this.employees.Remove(newEmployee);
        }

        public ICollection<Employee> EmployeeList
        {
            get
            {
                return this.employees;
            }
        }

        public void AddAnimal(Animal newAnimal)
        {
            this.animals.Add(newAnimal);
        }

        public void RemoveAnimal(Animal newAnimal)
        {
            this.animals.Remove(newAnimal);
        }
        public ICollection<Animal> AnimalsList
        {
            get
            {
                return this.animals;
            }
        }



        public void AddCage(Cage newCage)
        {
            this.cages.Add(newCage);
        }

        public void RemoveCage(Cage newCage)
        {
            this.cages.Remove(newCage);
        }

        public ICollection<Cage> GagelsList
        {
            get
            {
                return this.cages;
            }
        }

        public override string ToString()
        {
            StringBuilder schedule = new StringBuilder();
            schedule.AppendLine("Employees: ");
            foreach (var empl in employees)
            {
                schedule.AppendLine(string.Format("{0,7} {1} - {2}", empl.FirstName, empl.LastName, empl.StaffID));
            }

            schedule.AppendLine("Animals: ");
            foreach (var animal in animals)
            {
                //TODO Add Animal name
                schedule.AppendLine(string.Format("{0,7} - {2}", animal.Type, animal.AnimalID));
            }
            //schedule.AppendLine(string.Join(", ", this.animals));

            schedule.AppendLine("Cages: ");
            foreach (var cage in cages)
            {
                //TODO Add cages ID
                schedule.AppendLine(string.Format("{0,7}", cage.Type));
            }
            //schedule.Append(string.Join(", ", this.cages));

            return base.ToString() + schedule.ToString();
        }
    }
}
