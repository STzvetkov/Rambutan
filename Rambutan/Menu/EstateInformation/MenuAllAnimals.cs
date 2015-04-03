using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Menu.EstateInformation
{
    public class MenuAllAnimals : BaseMenuState
    {
        public MenuAllAnimals()
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
            get { return false; }
        }

        public override bool HasOptionTwo
        {
            get { return false; }
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
            get { return false; }
        }

        public override BaseMenuState OptionOne
        {
            get { throw new ArgumentException("No assigned menu."); }
        }

        public override BaseMenuState OptionTwo
        {
            get { throw new ArgumentException("No assigned menu."); }
        }

        public override BaseMenuState OptionThree
        {
            get { throw new ArgumentException("No assigned menu."); }
        }

        public override BaseMenuState OptionFour
        {
            get { throw new ArgumentException("No assigned menu."); }
        }

        public override BaseMenuState OptionFive
        {
            get { throw new ArgumentException("No assigned menu."); }
        }

    }
}
