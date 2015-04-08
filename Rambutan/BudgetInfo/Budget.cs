namespace Zoo.BudgetInfo
{
    using System;
    using System.Collections.Generic;
    using Zoo.Menu;

    public class Budget
    {
        private static Budget instance;
        private decimal netBudget;
        private Dictionary<string, decimal> expenseDictionary = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> incomeDictionary = new Dictionary<string, decimal>();
        
        private Budget()
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

        public void NetBudget()
        {
            bool isUsingTheShowExpenseMenu = true;
            while (isUsingTheShowExpenseMenu)
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

                Console.WriteLine("The net budget is: {0}", netBudget);

                Console.WriteLine("Press 0 to get back!");
                ConsoleKeyInfo userInput = Console.ReadKey();

                //Console.WriteLine("Feeding mammals"); 
                //Console.WriteLine("Food Left: {0}", meatFood);

                if (userInput.Key == ConsoleKey.D0)
                {
                    isUsingTheShowExpenseMenu = false;
                }
            }
        }

        public List<string> ShowExpense()
        {
            List<string> output = new List<string>();
            foreach (KeyValuePair<string, decimal> pair in expenseDictionary)
            {
                output.Add(String.Format("{0,-15} {1,8}",
                    pair.Key,
                    pair.Value));
            }
            return output;
        }

        public List<string> ShowIncome()
        {
            List<string> output = new List<string>();
            foreach (KeyValuePair<string, decimal> pair in incomeDictionary)
            {
                output.Add(String.Format("{0,-15} {1,8}",
                    pair.Key,
                    pair.Value));
            }
            return output;
        }

        public static Budget Instance
        {
            get
            {
                if (instance == null)
                    instance = new Budget();
                return instance;
            }
        }
    }
}