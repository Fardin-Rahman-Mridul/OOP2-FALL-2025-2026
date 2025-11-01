using System;

public class LabTaskNo4
{
    public static void MainTask4(string[] args)
    {
        Console.Write("Enter first number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Swapping using arithmetic operations
        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("\nAfter swapping:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        Console.ReadLine();
    }
}
