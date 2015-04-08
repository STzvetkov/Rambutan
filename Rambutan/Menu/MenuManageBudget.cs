namespace Zoo.Menu.ManageBudget
{
    using System;
    using Zoo.Exceptions;
    using System.Collections.Generic;
    using Zoo.BudgetInfo;
    

    public class MenuManageBudget : BaseMenuState
    {
        public override void PrintMenu()
        {            
            PrintHeader();
            int shift = (Console.WindowWidth - 20) / 2;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Print(12, shift, "1. Register income.");
            Print(15, shift, "2. Register expense.");
            Print(18, shift, "3. Show all income.");
            Print(21, shift, "4. Show all expenses.");
            Print(24, shift, "5. Net Budget (Income-Expenses)");
            Console.ForegroundColor = ConsoleColor.Red;
            Print(27, shift, "0. Main menu.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void OptionZero()
        {
            Start.state = new MainMenu();
        }

        public override void OptionOne()
        {
            ClearDetailsScreen();
            Print(12, (Console.WindowWidth / 2 + 20), "Enter income's type:");
            Print(15, (Console.WindowWidth / 2 + 20), "     ");
            string expenseName = Console.ReadLine();
            Print(18, (Console.WindowWidth / 2 + 20), "Enter income's amount:");
            Print(21, (Console.WindowWidth / 2 + 20), "     ");
            decimal incomeSum = decimal.Parse(Console.ReadLine());
            ZooManagement.BudgetInfo.AddExpense(expenseName, incomeSum);
        }

        public override void OptionTwo()
        {            
            ClearDetailsScreen();
            Print(12, (Console.WindowWidth / 2 + 20), "Enter expense's type:");
            Print(15, (Console.WindowWidth / 2 + 20), "        ");
            string expenseName = Console.ReadLine();
            Print(18, (Console.WindowWidth / 2 + 30), "Enter expense's amount:");
            Print(21, (Console.WindowWidth / 2 + 20), "        ");
            decimal expenseSum = decimal.Parse(Console.ReadLine());
            ZooManagement.BudgetInfo.AddExpense(expenseName, expenseSum);
        }

        public override void OptionThree()
        {
            ClearDetailsScreen();
            Print(12, (Console.WindowWidth / 2 + 30), "Incomes");
            Print(15, (Console.WindowWidth / 2 + 20), "Income type   //   Amount");
            int currentRow = 1;
            foreach (string income in ZooManagement.BudgetInfo.ShowIncome())
            {
                Print(15 + currentRow, (Console.WindowWidth / 2 + 20),income);
                currentRow++;
            }
            Console.ReadKey();            
        }

        public override void OptionFour()
        {
            ClearDetailsScreen();
            Print(12, (Console.WindowWidth / 2 + 30), "Incomes");
            Print(15, (Console.WindowWidth / 2 + 20), "Income type   //   Amount");
            int currentRow = 1;
            foreach (string expense in ZooManagement.BudgetInfo.ShowExpense())
            {
                Print(15 + currentRow, (Console.WindowWidth / 2 + 20), expense);
                currentRow++;
            }
            Console.ReadKey();  
        }

        public override void OptionFive()
        {
            //int n = int.Parse(Console.ReadLine());

            ZooManagement.BudgetInfo.NetBudget();
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
            get { return true; }
        }

        public override bool HasOptionFour
        {
            get { return true; }
        }

        public override bool HasOptionFive
        {
            get { return true; }
        }

        public override bool HasOptionSix
        {
            get { return false; ; }
        }
    }
}
