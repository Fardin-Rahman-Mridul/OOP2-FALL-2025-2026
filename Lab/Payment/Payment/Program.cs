using System;

abstract class Payment
{
    public abstract string ProcessPayment(double amount);
}

class BkashPayment : Payment
{
    public override string ProcessPayment(double amount)
    {
        return "Processing Bkash payment: " + amount;
    }
}

class CreditCardPayment : Payment
{
    public override string ProcessPayment(double amount)
    {
        return "Processing Credit Card payment: " + amount;
    }
}

class Program
{
    static void Main()
    {
        Payment p1 = new BkashPayment();
        Payment p2 = new CreditCardPayment();

        Console.WriteLine(p1.ProcessPayment(500));
        Console.WriteLine(p2.ProcessPayment(1200));
    }
}
