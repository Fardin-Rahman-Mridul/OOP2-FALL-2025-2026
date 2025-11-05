using System;

class MortgageCalculator
{
    static void Main()
    {
        Console.WriteLine("---Mortgage Calculator (Bangladesh)--");

        Console.Write("Enter loan amount: ");
        double loanAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter annual interest rate (in %): ");
        double annualRate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter loan period (in years): ");
        int years = Convert.ToInt32(Console.ReadLine());

        double monthlyRate = annualRate / 100 / 12;
        int totalMonths = years * 12;

        double monthlyPayment;
        if (monthlyRate == 0)
        {
            monthlyPayment = loanAmount / totalMonths;
        }
        else
        {
            double x = Math.Pow(1 + monthlyRate, totalMonths);
            monthlyPayment = loanAmount * (monthlyRate * x) / (x - 1);
        }

        //totals
        double totalPaid = monthlyPayment * totalMonths;
        double totalInterest = totalPaid - loanAmount;

        Console.WriteLine();
        Console.WriteLine("Monthly Payment: " + monthlyPayment.ToString("0.00") + " Taka");
        Console.WriteLine("Total Paid: " + totalPaid.ToString("0.00") + " Taka");
        Console.WriteLine("Total Interest: " + totalInterest.ToString("0.00") + " Taka");
    }
}
