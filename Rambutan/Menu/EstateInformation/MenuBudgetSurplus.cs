using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zoo.Exceptions;

namespace Zoo.Menu.EstateInformation
{
    public class MenuBudgetSurplus : BaseMenuState
    {
        public MenuBudgetSurplus()
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

        public override BaseMenuState OptionTwo
        {
            get { throw new NoMenuException("No assigned menu."); }
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
            get { throw new NoMenuException("No assigned menu."); }
        }

        public Zoo.Menu.ManageBudget.MenuManageBudget MenuManageBudget
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
