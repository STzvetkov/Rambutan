namespace Zoo.Menu.ManageBudget
{
    using System;
    using Zoo.Exceptions;

    public class MenuManageBudget : BaseMenuState
    {
        public override void PrintMenu()
        {            
            PrintHeader();
            int shift = (Console.WindowWidth - 20) / 2;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Print(12, shift, "1. Register income.");
            Print(15, shift, "2. Register expense.");
            Console.ForegroundColor = ConsoleColor.Red;
            Print(18, shift, "0. Main menu.");
            Console.ForegroundColor = ConsoleColor.White;
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
