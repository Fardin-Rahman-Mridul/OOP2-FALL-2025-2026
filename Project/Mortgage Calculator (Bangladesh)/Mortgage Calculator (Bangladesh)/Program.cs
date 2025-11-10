using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo bdCulture = new CultureInfo("bn-BD");
        Console.WriteLine("----Mortgage Calculator (Bangladesh)---\n");

        double salary = 0;
        double creditScore = 0;
        bool criminalRecord = false;

        //salary-----
        while (true)
        {
            Console.Write("Enter your monthly salary: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (double.TryParse(input, out salary))
                break;
            else
                Console.WriteLine("Invalid input! Please enter a numeric value.");
        }

        //credit score----
        while (true)
        {
            Console.Write("Enter your credit score (0-500): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim();

            if (double.TryParse(input, out creditScore))
            {
                if (creditScore >= 0 && creditScore <= 500)
                    break;
                else
                    Console.WriteLine("Credit score must be between 0 and 500.");
            }
            else
                Console.WriteLine("Invalid input! Please enter a numeric value between 0 and 500.");
        }

        //criminal----
        while (true)
        {
            Console.Write("Do you have a criminal record? (true/false): ");
            string input = (Console.ReadLine() ?? string.Empty).Trim().ToLower();

            if (bool.TryParse(input, out criminalRecord))
                break;
            else
                Console.WriteLine("Invalid input! Please type true or false.");
        }

        //eligibility----

        if (!(creditScore >= 300 && creditScore <= 500 && criminalRecord == false))
        {
            Console.WriteLine("\nSorry, you are not eligible for a loan.");
            Console.WriteLine("Reason: You must have a good credit score (300 - 500) and no criminal record.");
            return;
        }
        Console.WriteLine("\nYou are eligible! Proceeding with loan calculation...\n");

        //loan------
        double principal = 0;

        while (true)
        {
            Console.Write("Enter your desired loan amount: ");
            string input = Console.ReadLine() ?? string.Empty;

            if (double.TryParse(input, out principal))
            {
                if (principal <= (2 * salary))
                    break;
                else
                    Console.WriteLine($"Loan amount cannot be more than 2 times your salary. Max allowed: {(2 * salary).ToString("C", bdCulture)}");
            }
            else
                Console.WriteLine("Invalid input! Please enter a numeric value.");
        }

        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        //morgage calculation----
        double monthlyRate = annualRate / 100 / 12;
        int months = years * 12;

        double monthlyPayment = (principal * monthlyRate * Math.Pow(1 + monthlyRate, months))
                               / (Math.Pow(1 + monthlyRate, months) - 1);

        double totalPaid = monthlyPayment * months;
        double totalInterest = totalPaid - principal;

        //output-----
        Console.WriteLine("\n----- Mortgage Summary----");
        Console.WriteLine($"Monthly Salary: {salary.ToString("", bdCulture)} Taka");
        Console.WriteLine($"Credit Score: {creditScore} ");
        Console.WriteLine($"Criminal Record: {criminalRecord} ");
        Console.WriteLine($"Loan Amount: {principal.ToString("", bdCulture)} Taka");
        Console.WriteLine($"Monthly Payment: {monthlyPayment.ToString("", bdCulture)} Taka");
        Console.WriteLine($"Total Payment: {totalPaid.ToString("", bdCulture)} Taka");
        Console.WriteLine($"Total Interest: {totalInterest.ToString("", bdCulture)} Taka");
    }
}
