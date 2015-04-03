namespace Zoo.Menu
{
    using System;

    using Zoo.Menu.EstateInformation;
    using Zoo.Menu.ManageAnimals;
    using Zoo.Menu.ManageEmployees;
    using Zoo.Menu.ManageBudget;
    using Zoo.Menu.ManageSchedules;

    public class MainMenu : BaseMenuState
    {
        public MainMenu()
        {
        }

        public override void PrintMenu()
        {
            Print(6, 10, "1. Current estate information.");
            Print(9, 10, "2. Manage animals.");
            Print(12, 10, "3. Manage employees.");
            Print(15, 10, "4. Manage budget.");
            Print(18, 10, "5. Manage schedules.");
            Print(21, 10, "0. Exit.");
        }

        public override void OptionZero()
        {
            Start.programIsRunning = false;
            Console.Clear();

            Print(15, 10, "Thank you for using Team Rambutan's zoo management tool.");
            Print(17, 13, "Be sure to check for newer versions!");
            Console.SetCursorPosition(10, 22);
        }


        public override BaseMenuState OptionOne
        {
            get { return new MenuEstateInformation(); }
        }

        public override BaseMenuState OptionTwo
        {
            get { return new MenuManageAnimals(); }
        }

        public override BaseMenuState OptionThree
        {
            get { return new MenuManageEmployees(); }
        }

        public override BaseMenuState OptionFour
        {
            get { return new MenuManageBudget(); }
        }

        public override BaseMenuState OptionFive
        {
            get { return new MenuManageSchedules(); }
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
            get { return true; }
        }

        public override bool HasOptionFive
        {
            get { return true; ; }
        }

        public override bool HasOptionSix
        {
            get { return false; }
        }


    }
}
