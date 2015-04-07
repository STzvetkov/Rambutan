namespace Zoo.Menu
{
    using System;

    using Zoo.Menu.EstateInformation;
    using Zoo.Menu.ManageAnimals;
    using Zoo.Menu.ManageEmployees;
    using Zoo.Menu.ManageBudget;
    using Zoo.Menu.ManageSchedules;
    using Zoo.Menu.ManageFood;

    public class MainMenu : BaseMenuState
    {
        public MainMenu()
        {
        }

        public override void PrintMenu()
        {
            int shift = (Console.WindowWidth - 20) / 2;
            Console.ForegroundColor = ConsoleColor.Green;
            Print(6, shift, "1. Current estate information.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Print(9, shift, "2. Manage animals.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Print(12, shift, "3. Manage employees.");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Print(15, shift, "4. Manage budget.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Print(18, shift, "5. Manage schedules.");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Print(21, shift, "6. Manage food.");
            Console.ForegroundColor = ConsoleColor.Red;
            Print(24, shift, "0. Exit.");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public override void OptionZero()
        {
            Start.programIsRunning = false;
            Console.Clear();

            Print(15, 10, "Thank you for using Team Rambutan's zoo management tool.");
            Print(17, 13, "Be sure to check for newer versions!");
            Console.SetCursorPosition(10, 22);
        }


        public override void OptionOne()
        {
            Start.state = new MenuEstateInformation();
        }

        public override void OptionTwo()
        {
            Start.state = new MenuManageAnimals();
        }

        public override void OptionThree()
        {
            Start.state = new MenuManageEmployees();
        }

        public override void OptionFour()
        {
            Start.state = new MenuManageBudget();
        }

        public override void OptionFive()
        {
            Start.state = new MenuManageSchedules();
        }

        public override void OptionSix()
        {
            Start.state = new MenuManageFood();
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
            get { return true; }
        }
    }
}
