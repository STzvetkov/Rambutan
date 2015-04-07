namespace Zoo.Menu.ManageAnimals
{
    using System;
    using Zoo.Exceptions;

    public class MenuManageAnimals : BaseMenuState
    {
        public override void PrintMenu()
        {
            int shift = (Console.WindowWidth - 15) / 2;
            Console.ForegroundColor = ConsoleColor.Blue;
            Print(6, shift, "1. Buy animal(s).");
            Print(9, shift, "2. Sell animal(s).");
            Print(12, shift, "3. Buy cages.");
            Console.ForegroundColor = ConsoleColor.Red;
            Print(15, shift, "0. Back to Main menu.");
            Console.ForegroundColor = ConsoleColor.Blue;

        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }
        public override void OptionOne()
        {
            // TODO : Add method to buy animals.
            throw new NotImplementedException();
        }

        public override void OptionTwo()
        {
            // TODO : Add method to sell animals.
            throw new NotImplementedException();
        }

        public override void OptionThree()
        {
            // TODO : Add method to buy cages.
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
