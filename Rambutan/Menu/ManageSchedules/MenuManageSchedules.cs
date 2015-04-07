namespace Zoo.Menu.ManageSchedules
{
    using System;

    public class MenuManageSchedules : BaseMenuState
    {

        public override void PrintMenu()
        {
            Print(6, 10, "1. Change working schedules.");
            Print(9, 10, "2. Change feeding schedules.");
            Print(12, 10, "0. Back to Main menu.");

        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override BaseMenuState OptionOne
        {
            get { return new ManageWorkingSchedule(); }
        }

        public override BaseMenuState OptionTwo
        {
            get { return new ManageFeedingSchedule(); }
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

        public Zoo.Menu.MainMenu MainMenu
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
