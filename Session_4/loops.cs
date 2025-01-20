using System;

public class loops
{
    public static void Main(string[] args)
    {
        // for loop: we need to know the number of iterations
        for (int i = 0; i < 5; i++)
        {
            if(i==2)
            {
                continue;// skips the current iteration
            }
            if(i==4)
            {
                goto print;// jumps to the label
            }
            Console.WriteLine(i);
        }
    print:
        Console.WriteLine("End");
        // while loop: we need to know the condition and no need to know the number of iterations
        int j = 0; 
        while (j < 4)
        {
            Console.WriteLine(j);
            if(j== 2)
            {
                break;// exits the loop
            }
            j++;
        }

        // do while loop: checks the condition after executing the block of code
        int k = 8;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k < 4);

        // for each loop: used to iterate through the elements in an array or collection
        int[] arr = { 1, 2, 3, 4, 5 };
        foreach (int l in arr)
        {
            Console.Write(l + " ");
        }
    }
}
