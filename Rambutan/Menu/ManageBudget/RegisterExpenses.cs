﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo.Menu.ManageBudget
{
    public class RegisterExpenses : BaseMenuState
    {
        public override void PrintMenu()
        {
            Print(35, 10, "0. Return to Main menu.");
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
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
            get { return false; ; }
        }

        public MenuManageBudget MenuManageBudget
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
