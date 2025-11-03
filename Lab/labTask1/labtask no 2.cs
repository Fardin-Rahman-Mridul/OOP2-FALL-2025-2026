using System;

public class LabTaskNo2
{
    public static void MainTask2(string[] args) 
    {
        double originalPrice = 250.0;
        double discountRate = 15.0;

        double discountAmount = (originalPrice * discountRate) / 100.0;
        double finalPrice = originalPrice - discountAmount;

        Console.WriteLine("Original Price: $" + originalPrice);
        Console.WriteLine("Discount Rate: " + discountRate + "%");
        Console.WriteLine("Discount Amount: $" + discountAmount);
        Console.WriteLine("Final Price after Discount: $" + finalPrice);
        Console.ReadLine();
    }
}
