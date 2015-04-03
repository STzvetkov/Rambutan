namespace Zoo.Menu.ManageAnimals
{
    using System;

    public class MenuManageAnimals : BaseMenuState
    {

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

        public override void PrintMenu()
        {
            throw new NotImplementedException();
        }

        public override void OptionZero()
        {
            throw new NotImplementedException();
        }
    }
}
