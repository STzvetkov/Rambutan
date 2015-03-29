namespace Zoo.BudgetInfo
{
    using System;
    using System.Collections.Generic;

    public class Budget
    {
        
        private static Budget instance;
        private double netBudget;
        private Dictionary<string, double> expenseDictionary =
        new Dictionary<string, double>();
        private Dictionary<string, double> incomeDictionary =
        new Dictionary<string, double>();
        


        
        protected Budget()
        {}

        public void AddIncome(string incomeName, double incomeSum)
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

        public void AddExpense(string expenseName, double expenseSum)
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

        public double NetBudget()
        {
            netBudget = 0;
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

