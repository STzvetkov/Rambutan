namespace Zoo.Menu
{
    using System;

    public abstract class BaseMenuState
    {
        public abstract void PrintMenu();

        public abstract void OptionZero();

        public abstract bool HasOptionOne { get; }

        public abstract bool HasOptionTwo { get; }

        public abstract bool HasOptionThree { get; }

        public abstract bool HasOptionFour { get; }

        public abstract bool HasOptionFive { get; }

        public abstract bool HasOptionSix { get; }

        public abstract BaseMenuState OptionOne { get; }

        public abstract BaseMenuState OptionTwo { get; }

        public abstract BaseMenuState OptionThree { get; }

        public abstract BaseMenuState OptionFour { get; }

        public abstract BaseMenuState OptionFive { get; }

        protected void Print(int row, int col, object data)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(data);
        }
    }
}
