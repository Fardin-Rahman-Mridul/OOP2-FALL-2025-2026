using System;

public class LabTaskNo3
{
    public static void MainTask3(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);

        Console.ReadLine();
    }
}
