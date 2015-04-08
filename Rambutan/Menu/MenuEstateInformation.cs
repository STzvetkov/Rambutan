using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Exceptions;
using Zoo.Menu.EstateInformation;
using Zoo.Animals;

namespace Zoo.Menu.EstateInformation
{
    public class MenuEstateInformation : BaseMenuState
    {
        public MenuEstateInformation()
        {
        }

        public override void PrintMenu()
        {
            PrintHeader();
            int shift = (Console.WindowWidth - 20) / 2;
            Console.ForegroundColor = ConsoleColor.Green;
            Print(12, shift, "1. Number of empty cages.");
            Print(15, shift, "2. All animals.");
            Print(18, shift, "3. All employees.");
            Print(21, shift, "4. Food available.");
            Print(24, shift, "5. Budget surplus.");
            Console.ForegroundColor = ConsoleColor.Red;
            Print(27, shift, "0. Main menu.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override void OptionOne()
        {
            // TODO : Fill with method to show empty cages.
            ClearDetailsScreen();
            Print(12, (Console.WindowWidth / 2 + 30), "Empy cages");
            Print(15, (Console.WindowWidth / 2 + 20), "Cage type    //  Available");
            int currentRow = 1;
            foreach (HabitatType habitat in Enum.GetValues(typeof(HabitatType)))
            { 
                Print(15 + currentRow * 3, (Console.WindowWidth / 2 + 20),
                    String.Format("{0,-15}  {1,5}",
                        habitat, ZooManagement.CountCagesByTypeAndOccupation(habitat, 0)));
                currentRow++;
            }
            Console.ReadKey();
        }

        public override void OptionTwo()
        {
            // TODO : Fill with method to show all animals.
            ClearDetailsScreen();
            Print(12, (Console.WindowWidth / 2 + 30), "Animals");
            Print(15, (Console.WindowWidth / 2 + 20), "Animal type  //  Specimen");
            int currentRow = 1;
            foreach (AnimalSpeciesType animalType in Enum.GetValues(typeof(AnimalSpeciesType)))
            {
                Print(15 + currentRow, (Console.WindowWidth / 2 + 20),
                    String.Format("{0,-15}  {1,7}",
                        animalType, ZooManagement.CountAnimalsByType(animalType)));
                currentRow++;
            }
            Console.ReadKey();
        }

        public override void OptionThree()
        {
            // TODO : Fill with method to show all employees.
            ClearDetailsScreen();
            Print(12, (Console.WindowWidth / 2 + 30), "Employees");
            Print(15, (Console.WindowWidth / 2 + 20), "Animal type  //  Specimen");
            int currentRow = 1;
            foreach (AnimalSpeciesType animalType in Enum.GetValues(typeof(AnimalSpeciesType)))
            {
                Print(15 + currentRow, (Console.WindowWidth / 2 + 20),
                    String.Format("{0,-15}  {1,7}",
                        animalType, ZooManagement.CountAnimalsByType(animalType)));
                currentRow++;
            }
            Console.ReadKey();
        }

        public override void OptionFour()
        {
            // TODO : Fill with method to show all food available.
            throw new NotImplementedException();
        }

        public override void OptionFive()
        {
            // TODO : Fill with method to show budget surplus.
            throw new NotImplementedException();
        }

        public override void OptionSix()
        {
            throw new NoMenuException();
        }

        public override bool HasOptionOne
        {
            get
            {
                return true;
            }
        }

        public override bool HasOptionTwo
        {
            get
            {
                return true;
            }
        }

        public override bool HasOptionThree
        {
            get
            {
                return true;
            }
        }

        public override bool HasOptionFour
        {
            get
            {
                return true;
            }
        }

        public override bool HasOptionFive
        {
            get
            {
                return true;
            }
        }

        public override bool HasOptionSix
        {
            get
            {
                return true;
            }
        }
    }
}