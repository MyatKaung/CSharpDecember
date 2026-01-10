using Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{

    class Transaction
    {
        public int Amount;
        public string Category;
        public string Description;

        public Transaction(int amount, string category, string description)
        {
            Amount = amount;
            Category = category;
            Description = description;
        }
    }


    class Income : Transaction
    {
        public Income(int amount, string category, string description)
       : base(amount, category, description)
        {
        }
    }

    class Expense : Transaction
    {
        public Expense(int amount, string category, string description)
            : base(amount, category, description)
        {
        }
    }


    class Tracker
    {
        Income[] incomes = new Income[100];
        Expense[] expenses = new Expense[100];

        int incomeCount = 0, expenseCount = 0;

        public void AddIncome(Income income)
        {
            incomes[incomeCount] = income;
            incomeCount++;
        }

        public void AddExpense(Expense expense)
        {
            expenses[expenseCount] = expense;
            expenseCount++;
        }

        public void ShowAll()
        {
            Console.WriteLine("\nINCOME");
            for (int i = 0; i < incomeCount; i++)
            {
                Console.WriteLine($"{incomes[i].Category} | {incomes[i].Description} | {incomes[i].Amount}");
            }

            Console.WriteLine("\nEXPENSE");
            for (int i = 0; i < expenseCount; i++)
            {
                Console.WriteLine($"{expenses[i].Category} | {expenses[i].Description} | {expenses[i].Amount}");
            }
        }

        public int GetBalance()
        {
            int totalIncome = 0;
            int totalExpense = 0;

            for (int i = 0; i < incomeCount; i++)
                totalIncome += incomes[i].Amount;

            for (int i = 0; i < expenseCount; i++)
                totalExpense += expenses[i].Amount;

            return totalIncome - totalExpense;
        }
    }



}

internal class Program
    {
        static void Main(string[] args)
        {
        Tracker tracker = new Tracker();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n=== Expense Income Tracker ===");
            Console.WriteLine("1. Add Income");
            Console.WriteLine("2. Add Expense");
            Console.WriteLine("3. Show History");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                Console.Write("Enter income amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.Write("Enter income category: ");
                string category = Console.ReadLine();

                Console.Write("Enter income description: ");
                string description = Console.ReadLine();

                Income income = new Income(amount, category, description);
                tracker.AddIncome(income);

                Console.WriteLine("Income added successfully.");

            }
            else if (choice == 2)
            {
                Console.Write("Enter expense amount: ");
                int amount = int.Parse(Console.ReadLine());

                Console.Write("Enter expense category: ");
                string category = Console.ReadLine();

                Console.Write("Enter expense description: ");
                string description = Console.ReadLine();

                Expense expense = new Expense(amount, category, description);
                tracker.AddExpense(expense);

                Console.WriteLine("Expense added successfully.");

            }
            else if (choice == 3)
            {
                tracker.ShowAll();

            }
            else if (choice == 4)
            {
                int balance = tracker.GetBalance();
                Console.WriteLine("Current Balance: " + balance);
            }
            else if (choice == 0)
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        }



    }
    }

