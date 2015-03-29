namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using Employees;
    using Zoo.Animals;

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

        }
    }
}
