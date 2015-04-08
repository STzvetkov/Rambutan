namespace Zoo.BudgetInfo
{
    using System;
    using System.Collections.Generic;

    public class Budget
    {
        private static Budget instance;
        private decimal netBudget;
        private Dictionary<string, decimal> expenseDictionary = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> incomeDictionary = new Dictionary<string, decimal>();
        
        public Budget()
        {

        }

        public void AddIncome(string incomeName, decimal incomeSum)
        {
            if (incomeSum <= 0)
            {
                throw new ArgumentException("Income should be a positive number!");
            }
            
            try
            {
                
                incomeDictionary.Add(incomeName, incomeSum);
            }
            catch (Exception)
            {
                throw new ArgumentException("Incorect input! First write a string for the name of the income, then a decimal for the sum!");
            }
        }


        public void RemoveIncome(string incomeName)
        {
            try
            {


                incomeDictionary.Remove(incomeName);
            }
            catch (Exception)
            {
                throw new ArgumentException("Incorect input! Write an exsisting income name!");
            }
        }


        public void AddExpense(string expenseName, decimal expenseSum)
        {

            if (expenseSum <= 0)
            {
                throw new ArgumentException("Expenses should be a positive number!");
            }
            try
            {
                expenseDictionary.Add(expenseName, expenseSum);
            }
            catch (Exception)
            {
                throw new ArgumentException("Incorect input! First write a string for the name of the expense, then a decimal for the sum!");
            }
        }

        public void RemoveExpense(string incomeName)
        {
            try
            {
                expenseDictionary.Remove(incomeName);
            }
            catch (Exception)
            {
                throw new ArgumentException("Incorect input! Write an exsisting expense name!");
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


        public Dictionary<string, decimal> ShowExpense()
        {

            return expenseDictionary;
        }

        public Dictionary<string, decimal> ShowIncome()
        {

            return incomeDictionary;
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

