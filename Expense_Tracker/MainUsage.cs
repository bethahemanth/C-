using System;
using model;
public class MainUsage
{
    public static void Main(string[] args)
    {
        dynamic a = 5;
        a = "Hello";
        System.Console.WriteLine(a);
        Expense.l.Add(new Expense(new DateTime(2025, 01, 01), "Food", 45.00, "Groceries"));
        model_as_parameter.saveExpenses(new Expense(new DateTime(2025, 01, 01), "Food", 45.00, "Groceries"));
        while (true)
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1: To add an expense");
            Console.WriteLine("2: To view all expenses");
            Console.WriteLine("3: To exit");

            int r;
            if (!int.TryParse(Console.ReadLine(), out r)) // Input validation
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (r)
            {
                case 1:
                    Console.WriteLine("Adding an expense...");
                    Expense.AddExpense();
                    break;
                case 2:
                    Console.WriteLine("Viewing all expenses...");
                    Expense.ViewAllExpenses();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break; // Break the loop when the user chooses to exit
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            if (r == 3) // Additional break condition for clarity
            {
                break;
            }
        }

    }
}
