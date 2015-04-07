namespace Zoo.Menu.ManageAnimals
{
    using System;
    using Zoo.Exceptions;

    public class MenuManageAnimals : BaseMenuState
    {
        public override void PrintMenu()
        {
            Print(6, 10, "1. Buy animal(s).");
            Print(9, 10, "2. Sell animal(s).");
            Print(12, 10, "3. Buy cages.");
            Print(15, 10, "0. Back to Main menu.");

        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }
        public override void OptionOne()
        {
            // TODO : Add method to buy animals.
        }

        public override void OptionTwo()
        {
            // TODO : Add method to sell animals.
        }

        public override void OptionThree()
        {
            // TODO : Add method to buy cages.
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
