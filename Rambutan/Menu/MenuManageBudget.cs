﻿namespace Zoo.Menu.ManageBudget
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
            Print(24, shift, "5. Net Budget (Income - Expenses)");
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
            Console.WriteLine("Please write the name of the income you want to register e.g \"Sponsorship\"");
            string incomeName = Console.ReadLine();
            Console.WriteLine("Please write the amount of income you want to register for {0}", incomeName);
            decimal incomeSum = decimal.Parse(Console.ReadLine());
            ZooManagement.BudgetInfo.AddIncome(incomeName, incomeSum);

            
        }

        public override void OptionTwo()
        {
            Console.WriteLine("Please write the name of the expenses you want to register e.g \"Wedding for the Tiger\"");
            string expenseName = Console.ReadLine();
            Console.WriteLine("Please write the amount of expenses you want to register for {0}", expenseName);
            decimal expenseSum = decimal.Parse(Console.ReadLine());
            ZooManagement.BudgetInfo.AddExpense(expenseName, expenseSum);



        }

        public override void OptionThree()
        {
            
            foreach (KeyValuePair<string, decimal> pair in ZooManagement.BudgetInfo.ShowIncome())
            {
                Console.WriteLine("{0}, {1}",
                pair.Key,
                pair.Value);
            }

            
        }

        public override void OptionFour()
        {

            
            foreach (KeyValuePair<string, decimal> pair in ZooManagement.BudgetInfo.ShowExpense())
            {
                Console.WriteLine("{0}, {1}",
                pair.Key,
                pair.Value);
            }

            
        }

        public override void OptionFive()
        {
            //int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("The net budget is " + ZooManagement.BudgetInfo.NetBudget());
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
