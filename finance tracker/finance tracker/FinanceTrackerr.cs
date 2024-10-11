using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finance_tracker
{
    public class FinanceTrackerr
    {


        private List<Transaction> transactions = new List<Transaction>();
        private List<Budget> budgets = new List<Budget>();
        private List<savingsGoal> savingsGoals = new List<savingsGoal>();

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Personal Finance Tracker");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. Set Budget");
                Console.WriteLine("3. View Financial Report");
                Console.WriteLine("4. Add Savings Goal");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddExpense();
                        break;
                    case "2":
                        SetBudget();
                        break;
                    case "3":
                        ViewReport();
                        break;
                    case "4":
                        AddSavingsGoal();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void AddExpense()
        {
            Console.Write("Enter Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            var transaction = new Transaction
            {
                Amount = amount,
                Category = category,
                Date = DateTime.Now
            };

            transactions.Add(transaction);
            Console.WriteLine("Expense added! Press any key to continue.");
            Console.ReadKey();
            }
            private void SetBudget()
            {
            Console.Write("Enter Budget Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Budget Limit: ");
            decimal limit = decimal.Parse(Console.ReadLine());

            budgets.Add(new Budget { Category = category, Limit = limit });
            Console.WriteLine("Budget set! Press any key to continue.");
            Console.ReadKey();
        }

        private void ViewReport()
        {
             Console.WriteLine("Financial Report");
            Console.WriteLine("----------------");

            decimal totalExpenses = 0;
            foreach (var transaction in transactions)
            {
                totalExpenses += transaction.Amount;
                Console.WriteLine("{transaction.Date}: {transaction.Category} - {transaction.Amount:C}");
            }

            Console.WriteLine("Total Expenses: {totalExpenses:C}");
            Console.WriteLine("----------------");

            foreach (var budget in budgets)
            {
                Console.WriteLine("{budget.Category}: {budget.Limit:C}");
            }

            Console.WriteLine("----------------");
            Console.WriteLine("Savings Goals:");
            foreach (var goal in savingsGoals)
            {
                Console.WriteLine("{goal.GoalName}: Target - {goal.TargetAmount:C}, Current - {goal.CurrentAmount:C}");
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private void AddSavingsGoal()
        {
            Console.Write("Enter Goal Name: ");
            string goalName = Console.ReadLine();

            Console.Write("Enter Target Amount: ");
            decimal targetAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Current Amount: ");
            decimal currentAmount = decimal.Parse(Console.ReadLine());

            // Correctly create a new SavingsGoal instance
            var savingsGoal = new savingsGoal
            {
                GoalName = goalName,
                TargetAmount = targetAmount,
                CurrentAmount = currentAmount
            };

            savingsGoals.Add(savingsGoal); // Add to the list
            Console.WriteLine("Savings goal added! Press any key to continue.");
            Console.ReadKey();
        }
    }
}



   