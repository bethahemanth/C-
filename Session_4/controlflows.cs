using System;

public class control_flow_statement
{
    public static void Main(string[] args)
    {
        int marks = 35;
        // if-else statement
        if (marks>=90)
        {
            Console.WriteLine("Grade A");
        }
        else if (marks>=75)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade C");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade F");
        }
        //switch statement
        switch (marks)
        {
            case 90:
                Console.WriteLine("Grade A");
                break;
            case 75:
                Console.WriteLine("Grade B");
                break;
            case 60:
                Console.WriteLine("Grade C");
                break;
            case 50:
                Console.WriteLine("Grade D");
                break;
            default:
                Console.WriteLine("Grade F");
                break;
        }
        //ternary operator  
        string res=(marks>=35)?"Pass":"Fail";
        Console.WriteLine(res);
    }
