namespace Zoo.Menu.ManageSchedules
{
    using System;
    using Zoo.Exceptions;

    public class MenuManageSchedules : BaseMenuState
    {

        public override void PrintMenu()
        {
            PrintHeader();
            int shift = (Console.WindowWidth - 20) / 2;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Print(12, shift, "1. Change working schedules.");
            Print(15, shift, "2. Change feeding schedules.");
            Console.ForegroundColor = ConsoleColor.Red;
            Print(18, shift, "0. Back to Main menu.");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override void OptionOne()
        {
            //TODO : Add method to change working schedules.
        }

        public override void OptionTwo()
        {
            //TODO : Add method to change feeding schedules.
        }

        public override void OptionThree()
        {
            throw new NoMenuException();
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
    }
}
