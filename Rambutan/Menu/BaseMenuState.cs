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
    }
}
