
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
            PrintHeader();
            int shift = (Console.WindowWidth - 20) / 2;

            Console.ForegroundColor = ConsoleColor.DarkYellow;            
            Print(12, shift, "1. Order food.");
            Print(15, shift, "2. Feed animals.");

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
            Console.Clear();
            FoodManipulations.OrderFood();
        }

        public override void OptionTwo()
        {
            FoodManipulations.FeedAnimals();
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
