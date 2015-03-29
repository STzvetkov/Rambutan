namespace Zoo.BudgetInfo
{
    using System;
    using System.Collections.Generic;

    public class Budget
    {
        private static Budget instance;
        private decimal netBudget;
        private readonly Dictionary<string, decimal> expenseDictionary = new Dictionary<string, decimal>();
        private readonly Dictionary<string, decimal> incomeDictionary = new Dictionary<string, decimal>();
        
        public Budget()
        {

        }

        public void AddIncome(string incomeName, decimal incomeSum)
        {
            try
            {
                expenseDictionary.Add(incomeName, incomeSum);
            }
            catch (Exception)
            {
                throw new ArgumentException("Incorect input! First write a string for the name of the income, then a double for the sum!");
            }
        }

        public void AddExpense(string expenseName, decimal expenseSum)
        {
            try
            {
                expenseDictionary.Add(expenseName, expenseSum);
            }
            catch (Exception)
            {
                throw new ArgumentException("Incorect input! First write a string for the name of the expense, then a double for the sum!");
            }
        }

        public decimal NetBudget()
        {
            netBudget = 0.0M;

            foreach (var item in expenseDictionary)
            {
                netBudget -= item.Value;
            }

            foreach (var item in incomeDictionary)
            {
                netBudget += item.Value;
            }

            return netBudget;
        }

        public static Budget Instance()
        {
            if (instance == null)
            {
                instance = new Budget();
            }

            return instance;
        }
    }
}

