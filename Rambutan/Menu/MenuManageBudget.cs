namespace Zoo.Menu.ManageBudget
{
    using System;
    using Zoo.Exceptions;

    public class MenuManageBudget : BaseMenuState
    {
        public override void PrintMenu()
        {
            Print(6, 10, "1. Register income.");
            Print(9, 10, "2. Register expense.");
            Print(12, 10, "0. Back to Main menu.");
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override void OptionOne()
        {
            // TODO : Add method to register income.
            throw new NotImplementedException();
        }

        public override void OptionTwo()
        {
            // TODO : Add method to register expense.
            throw new NotImplementedException();
        }

        public override void OptionThree()
        {
            throw new NoMenuException();
        }

        public override void OptionFour()
        {
            throw new NoMenuException();
        }

        public override void OptionFive()
        {
            throw new NoMenuException();
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
            get { return false; }
        }

        public override bool HasOptionFour
        {
            get { return false; }
        }

        public override bool HasOptionFive
        {
            get { return false; }
        }

        public override bool HasOptionSix
        {
            get { return false; ; }
        }
    }
}
