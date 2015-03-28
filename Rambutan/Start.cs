namespace Zoo
{
    using System;
    using System.Collections.Generic;

    using Employees;


    class Start
    {
        static void Main()
        {
            // <test>
            var nutr = new Nutritionist();
            nutr.AnimalsFedDaily = 3;
            nutr.MonthlySalary = 2000.00;

            var vet = new Veterinarian();
            vet.MonthlySalary = 1999.00;
            vet.AnimalsTreatedDaily = 4;

            Console.WriteLine(nutr);
            Console.WriteLine(vet);
            // </test>
        }
    }
}
