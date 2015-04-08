namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using Employees;
    using Zoo.Animals;
    using Zoo.Animals.Consumables;
    using Zoo.Schedules;
    using Zoo.Menu;
    using Zoo.Common;


    class Start
    {
        static ConsoleKeyInfo cki;
        public static BaseMenuState state;
        public static bool programIsRunning = true;

        static IEnumerable<VersionAttribute> attr = typeof(ZooManagement).GetCustomAttributes<VersionAttribute>();

        static void Main()
        {
            Console.SetWindowSize(100, 45);
            Console.WindowHeight = 45;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = 100;
            Console.BufferWidth = Console.WindowWidth;


            ZooManagement.Init();
           
            #region Menu
            state = new MainMenu();
            Console.CursorVisible = false;

            while (programIsRunning)
            {
                Console.Clear();
                state.PrintMenu();

                GetVersion();

                ReadKey();
                TakeChoice(cki);
            }
            #endregion
        }

        public static void GetVersion()
        {
            foreach (var attribute in attr)
            {
                Print(43, 60, string.Join(", ", attribute.Component, attribute.Name, attribute.Version));
            }
        }

        #region MenuMethods
        private static void Print(int row, int col, object data)
        {
            Console.SetCursorPosition(col, row);
            Console.Write(data);
        }

        private static void ReadKey()
        {
            Console.SetCursorPosition(5, 5);
            cki = Console.ReadKey();
            Console.SetCursorPosition(5, 5);
            Console.Write(" ");
        }

        private static void TakeChoice(ConsoleKeyInfo cki)
        {
            switch (cki.Key)
            {
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    state.OptionZero();
                    break;

                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    if (state.HasOptionOne)
                    {
                        state.OptionOne();
                    }
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    if (state.HasOptionTwo)
                    {
                       state.OptionTwo();
                    }
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    if (state.HasOptionThree)
                    {
                        state.OptionThree();
                    }
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    if (state.HasOptionFour)
                    {
                        state.OptionFour();
                    }
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    if(state.HasOptionFive)
                    {
                        state.OptionFive();
                    }
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    if (state.HasOptionSix)
                    {
                        state.OptionSix();
                    }
                    break;

                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    break;

                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    break;

                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    break;

                default:
                    break;
            }
        }
        #endregion
    }
}
