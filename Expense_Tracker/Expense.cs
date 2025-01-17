using System;
using System.Collections.Generic;
namespace model
{
    public class Expense
    {
        private DateTime date;
        private string category;
        private double amount;
        private string description;

        public DateTime _date
        {
            get { return date; }
            set { date = value; }
        }

        public Expense(DateTime date, string category, double amount, string description)
        {
            this.date = date;
            this.category = category;
            this.amount = amount;
            this.description = description;
        }

        public static List<Expense> l = new List<Expense>();

        public static void AddExpense()
        {
            Console.WriteLine("Enter the date (yyyy-MM-dd):");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter the category:");
            string category = Console.ReadLine();

            Console.WriteLine("Enter the amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the description:");
            string description = Console.ReadLine();

            Expense newExpense = new Expense(date, category, amount, description);
            l.Add(newExpense);
        }

        public static void ViewAllExpenses()
        {
            foreach (Expense expense in l)
            {
                Console.WriteLine(expense);
            }
        }

        public override string ToString()
        {
            return $"Date: {date.ToShortDateString()}, Category: {category}, Amount: ${amount:F2}, Description: {description}";
        }
    }
}