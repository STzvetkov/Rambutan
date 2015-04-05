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


            var vet = new Veterinarian();
            vet.AnimalsTreatedDaily = 4;

            Console.WriteLine(nutr);
            Console.WriteLine(vet);
            // </test>

            Food newF = new Food(1000);

            newF.ConsumeAmount(500);
            Console.WriteLine(newF.GetQuantity());

            var schedule = new WorkingSchedule("Visit","11:15","Weekly");
            schedule.AddDay(DayOfWeek.Sunday);
            schedule.AddDay(DayOfWeek.Tuesday);
            schedule.AddDay(DayOfWeek.Monday);
            schedule.AddTime("15:15");
            schedule.AddTime("18:15");
            schedule.AddTime("09:15");
            schedule.AddEployee(new Veterinarian("Bai", "Krustio"));
            

            Console.WriteLine(schedule);

            //var schedule2 = new WorkingSchedule("cleaning","12:30");
            
            // test event
            FeedingAnimalAndOrderingFood.CreateFood();
            

        }
    }
}
