using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zoo.Exceptions;
using Zoo.Animals.Consumables;

namespace Zoo.Menu.EstateInformation
{
    public class MenuFoodAvailable : BaseMenuState
    {
        public MenuFoodAvailable()
        {
        }

        public override void PrintMenu()
        {
            Print(6, 10, "1. Available Food");
            Print(9, 10, "2. Order Food");
            Print(21, 10, "0. Return to Main menu.");
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
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
            get { throw new NoMenuException("No assigned menu."); } // food instance.Available
        }

        public override BaseMenuState OptionTwo
        {
            get { throw new NoMenuException("No assigned menu."); } // FoodManipulations.CreateFood();
        }

        public override BaseMenuState OptionThree
        {
            get { throw new NoMenuException("No assigned menu."); }
        }

        public override BaseMenuState OptionFour
        {
            get { throw new NoMenuException("No assigned menu."); }
        }

        public override BaseMenuState OptionFive
        {
            get { throw new NoMenuException("No assigned menu."); }
        }



    }
}
