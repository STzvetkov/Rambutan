namespace Zoo.Menu.ManageEmployees
{
    using System;
    using Zoo.Exceptions;

    public class MenuManageEmployees : BaseMenuState
    {

        public override void PrintMenu()
        {
            PrintHeader();
            int shift = (Console.WindowWidth - 20) / 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Print(12, shift, "1. Register hired employee.");
            Print(15, shift, "2. Register fired employee.");
            Print(18, shift, "3. Manage salaries.");
            Console.ForegroundColor = ConsoleColor.Red;
            Print(21, shift, "0. Back to Main menu.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override void OptionOne()
        {
            // TODO : Add method to register hired employee.
            throw new NotImplementedException();
        }

        public override void OptionTwo()
        {
            // TODO : Add method to register fired employee.
            throw new NotImplementedException();
        }

        public override void OptionThree()
        {
            // TODO : Add method to manage salaries.
            throw new NotImplementedException();
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
    }
}
