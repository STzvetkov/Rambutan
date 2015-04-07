using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Menu.ManageAnimals
{
    public class MenuBuyAnimals : BaseMenuState
    {
        public MenuBuyAnimals()
        {
        }

        public override void PrintMenu()
        {
            Print(35, 10, "0. Return to Main menu.");
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override bool HasOptionOne
        {
            get { throw new NotImplementedException(); }
        }

        public override bool HasOptionTwo
        {
            get { throw new NotImplementedException(); }
        }

        public override bool HasOptionThree
        {
            get { throw new NotImplementedException(); }
        }

        public override bool HasOptionFour
        {
            get { throw new NotImplementedException(); }
        }

        public override bool HasOptionFive
        {
            get { throw new NotImplementedException(); }
        }

        public override bool HasOptionSix
        {
            get { throw new NotImplementedException(); }
        }

        public override BaseMenuState OptionOne
        {
            get { throw new NotImplementedException(); }
        }

        public override BaseMenuState OptionTwo
        {
            get { throw new NotImplementedException(); }
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

        public MenuManageAnimals MenuManageAnimals
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
