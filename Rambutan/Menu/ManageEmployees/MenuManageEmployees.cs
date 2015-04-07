namespace Zoo.Menu.ManageEmployees
{
    using System;

    public class MenuManageEmployees : BaseMenuState
    {

        public override void PrintMenu()
        {
            Print(6, 10, "1. Register hired employee.");
            Print(9, 10, "2. Register fired employee.");
            Print(12, 10, "3. Manage salaries.");
            Print(15, 10, "0. Back to Main menu.");
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override BaseMenuState OptionOne
        {
            get { return new RegisterHiredEmployee(); }
        }

        public override BaseMenuState OptionTwo
        {
            get { return new RegisterFiredEmployee(); }
        }

        public override BaseMenuState OptionThree
        {
            get { return new ManageSalaries(); }
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
            get { return true; }
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

        public Zoo.Menu.MainMenu MainMenu
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
