namespace Zoo.Menu.ManageAnimals
{
    using System;

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
        public override BaseMenuState OptionOne
        {
            get { return new MenuBuyAnimals(); }
        }

        public override BaseMenuState OptionTwo
        {
            get { return new MenuSellAnimals(); }
        }

        public override BaseMenuState OptionThree
        {
            get { return new MenuBuyCages(); }
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

    }
}
