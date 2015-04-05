namespace Zoo.Menu.ManageBudget
{
    using System;

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
        public override BaseMenuState OptionOne
        {
            get { return new RegisterExpenses(); }
        }

        public override BaseMenuState OptionTwo
        {
            get { return new RegisterIncome(); }
        }

        public override BaseMenuState OptionThree
        {
            get { throw new NotImplementedException(); }
        }

        public override BaseMenuState OptionFour
        {
            get { throw new NotImplementedException(); }
        }

        public override BaseMenuState OptionFive
        {
            get { throw new NotImplementedException(); }
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
