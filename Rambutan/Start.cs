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

        static void Main()
        {
            // <test>
            var nutr = new Nutritionist();
            nutr.AnimalsFedDaily = 3;


            var vet = new Veterinarian();
            vet.AnimalsTreatedDaily = 4;

            Console.WriteLine(nutr);
            Console.WriteLine(vet);
            // </test>

            Food newF = new Food(1000);

            newF.ConsumeAmount(500);
            Console.WriteLine(newF.GetQuantity());

            var schedule = new Schedule("11:15", Zoo.Schedules.Schedule.Frequency.weekly); // kak da se sykrati?
            schedule.AddDay(DayOfWeek.Sunday);

            // test event
            //FeedingAnimalAndOrderingFood.CreateFood();

            Console.WindowHeight = 45;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = 100;
            Console.BufferWidth = Console.WindowWidth;

            var attr = typeof(ZooManagement).GetCustomAttributes<VersionAttribute>();



            #region Menu
            ChangeMenu(new MainMenu());

            Console.CursorVisible = false;

            while (programIsRunning)
            {
                Console.Clear();
                state.PrintMenu();
                
                foreach (var attribute in attr)
                {
                    Print(43, 60, string.Join(", ", attribute.Component,attribute.Name,attribute.Version));
                }
                ReadKey();
                TakeChoice(cki);



            }
            #endregion
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
                        ChangeMenu(state.OptionOne);
                    }
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    if (state.HasOptionTwo)
                    {
                        ChangeMenu(state.OptionTwo);
                    }
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    if (state.HasOptionThree)
                    {
                        ChangeMenu(state.OptionThree);
                    }
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    if (state.HasOptionFour)
                    {
                        ChangeMenu(state.OptionFour);
                    }
                    break;

                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    break;

                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
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

        private static void ChangeMenu(BaseMenuState menu)
        {
            state = menu;
        }
        #endregion
    }
}
