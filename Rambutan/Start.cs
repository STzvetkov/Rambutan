namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using Employees;
    using Zoo.Animals;
    using Zoo.Animals.Consumables;
    using Zoo.Schedules;

    class Start
    {
        static void Main()
        {
            // <test>
            var nutr = new Nutritionist();
            nutr.AnimalsFedDaily = 3;
            nutr.MonthlySalary = 2000.00M;

            var vet = new Veterinarian();
            vet.MonthlySalary = 1999.00M;
            vet.AnimalsTreatedDaily = 4;

            Console.WriteLine(nutr);
            Console.WriteLine(vet);
            // </test>

            Food newF = new Food(1000);

            newF.ConsumeAmount(500);
            Console.WriteLine(newF.GetQuantity());

            //var schedule = new Schedule("11:15",Frequency.weekly);
            //schedule.AddDay(DayOfWeek.Sunday);


        }
    }
}
