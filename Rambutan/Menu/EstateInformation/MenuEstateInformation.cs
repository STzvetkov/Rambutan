using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Menu.EstateInformation;

namespace Zoo.Menu.EstateInformation
{
    public class MenuEstateInformation : BaseMenuState
    {

        public MenuEstateInformation()
        {
        }




        public override void PrintMenu()
        {
            Print(6, 10, "1. Number of empty cages.");
            Print(9, 10, "2. All animals.");
            Print(12, 10, "3. All employees.");
            Print(15, 10, "4. Food operations.");
            Print(18, 10, "5. Budget surplus.");
            Print(21, 10, "0. Back to Main menu.");

        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override BaseMenuState OptionOne
        {
            get { return new MenuNumberOfCages(); }
        }

        public override BaseMenuState OptionTwo
        {
            get { return new MenuAllAnimals(); }
        }

        public override BaseMenuState OptionThree
        {
            get { return new MenuAllEmployees(); }
        }

        public override BaseMenuState OptionFour
        {
            get { return new MenuFoodAvailable(); }
        }

        public override BaseMenuState OptionFive
        {
            get { return new MenuBudgetSurplus(); }
        }

        public override bool HasOptionOne
        {
            get { return true; }
        }

        public override bool HasOptionTwo
        {
            get { return true; }
        }

        public override bool HasOptionThree
        {
            get { return true; }
        }

        public override bool HasOptionFour
        {
            get { return true; }
        }

        public override bool HasOptionFive
        {
            get { return true; }
        }

        public override bool HasOptionSix
        {
            get { return true; }
        }
    }
}
