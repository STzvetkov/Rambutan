
namespace Zoo.Menu.ManageFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Zoo.Animals.Consumables;
    using Zoo.Exceptions;

    public class MenuManageFood : BaseMenuState
    {
        public override void PrintMenu()
        {
            Print(6, 10, "1. Feed animals");
            Print(9, 10, "2. Order Food");
            Print(12, 10, "0. Back to Main menu");
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override void OptionOne()
        {
            Console.Clear();
            FoodManipulations.FeedAnimals();
        }

        public override void OptionTwo()
        {
            throw new NoMenuException();
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
    }
}
