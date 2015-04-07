namespace Zoo.Menu
{
    using System;

    public abstract class BaseMenuState
    {
        public abstract void PrintMenu();

        public abstract void OptionZero();

        public abstract void OptionOne();

        public abstract void OptionTwo();

        public abstract void OptionThree();

        public abstract void OptionFour();

        public abstract void OptionFive();

        public abstract void OptionSix();

        public abstract bool HasOptionOne { get; }

        public abstract bool HasOptionTwo { get; }

        public abstract bool HasOptionThree { get; }

        public abstract bool HasOptionFour { get; }

        public abstract bool HasOptionFive { get; }

        public abstract bool HasOptionSix { get; }

        protected void Print(int row, int col, object data)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(data);
        }

        protected void PrintHeader()
        {

            int shift = (Console.WindowWidth - 30) / 2;
            Console.ForegroundColor = ConsoleColor.Green;

            Print(1, shift, "     _oo     .-.        .-.    ");
            Print(2, shift,   "  >-(_  \\  c(O_O)c    c(O_O)c   ");
            Print(3, shift,   "     / _/ ,'.---.`,  ,'.---.`,   ");
            Print(4, shift,   "    / /  / /|_|_|\\ \\/ /|_|_|\\ \\ ");
            Print(5, shift,   "   / (   | \\_____/ || \\_____/ | ");
            Print(6, shift, "  (   `-.'. `---' .`'. `---' .` ");
            Print(7, shift,   "   `--.._) `-...-'    `-...-'   ");
        }

        protected void ClearDetailsScreen()
        {
            for (int i = 12; i < 36; i++)
            {
                Print(i, (Console.WindowWidth / 2 +20), "                                                ");
            }
        }
    }
}
