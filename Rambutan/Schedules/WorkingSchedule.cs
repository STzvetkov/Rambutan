namespace Zoo.Schedules
{
    using System;
    using Zoo.Employees;
    using Zoo.Animals;
    using System.Collections.Generic;

    public class WorkingSchedule : Schedule
    {
        // TODO : Throw exception "Not implemented yet."

        // once a week veterinary exam at certain cage
        private string workType { get; set; }

        private List<Employee> employees;

        private List<Animal> animals;

        private List<Cage> cages;

        public string description { get; set; }

        public WorkingSchedule(string typeOfWork)
        {
            this.workType = typeOfWork;
        }



        public void AddEployee(Employee newEmployee)
        {
            this.employees.Add(newEmployee);
        }

        public void RemoveEmployee(Employee newEmployee)
        {
            this.employees.Remove(newEmployee);
        }

        public List<Employee> EmployeeList
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
        public List<Animal> AnimalsList
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

        public List<Cage> GagelsList
        {
            get
            {
                return this.cages;
            }
        }
    }
}
