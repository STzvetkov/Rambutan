using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Exceptions;
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
            Print(15, 10, "4. Food available.");
            Print(18, 10, "5. Budget surplus.");
            Print(21, 10, "0. Back to Main menu.");
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override void OptionOne()
        {
           // TODO : Fill with method to show empty cages.
            throw new NotImplementedException();
        }

        public override void OptionTwo()
        {
            // TODO : Fill with method to show all animals.
            throw new NotImplementedException();
        }

        public override void OptionThree()
        {
            // TODO : Fill with method to show all employees.
            throw new NotImplementedException();
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
